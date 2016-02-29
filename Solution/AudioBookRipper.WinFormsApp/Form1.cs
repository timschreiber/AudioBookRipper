using NAudio.Lame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using Ripper;
using System.Text.RegularExpressions;
using System.Threading;
using NAudio.Wave;

namespace AudioBookRipper.WinFormsApp
{
    public partial class Form1 : Form
    {
        private int _currentDisc;
        private Yeti.MMedia.WaveWriter _wr;
        private int _trackNum;
        private int _discTracks;
        private uint _trackPos;
        private uint _trackLen;
        private uint _discPos;
        private uint _discLen;
        private bool _cancel = false;
        private string _bookPath;
        private bool _done = false;
    
        public Form1()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var defaultFolder = Environment.ExpandEnvironmentVariables(ConfigurationManager.AppSettings["DefaultStorageLocation"]);
            if (!Directory.Exists(defaultFolder))
                Directory.CreateDirectory(defaultFolder);
            txtSaveToFolder.Text = defaultFolder;
            folderBrowserDialog1.SelectedPath = defaultFolder;

            cbQuality.ValueMember = "Value";
            cbQuality.DisplayMember = "Name";
            cbQuality.DataSource = getLamePresets();
            cbQuality.SelectedValue = (int)LAMEPreset.STANDARD;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var dialogResult = folderBrowserDialog1.ShowDialog();
            if(dialogResult == DialogResult.OK)
                txtSaveToFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private IList<NameValuePair<int>> getLamePresets()
        {
            var result = new List<NameValuePair<int>>();
            var values = Enum.GetValues(typeof(LAMEPreset));
            foreach(var value in values)
            {
                var name = Enum.GetName(typeof(LAMEPreset), value);
                result.Add(new NameValuePair<int> { Name = name, Value = (int)value });
            }
            return result;
        }

        private bool validate()
        {
            var msgs = new List<string>();
            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
                msgs.Add("Author is required.");
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
                msgs.Add("Title is required.");
            var ok = msgs.Count == 0;
            if (!ok)
                MessageBox.Show(this, string.Join("\n\n", msgs), "Validation errors:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return ok;
        }

        private string coerceValidFileName(string filename)
        {
            var invalidChars = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
            var invalidReStr = string.Format(@"[{0}]+", invalidChars);

            var reservedWords = new[]
                                    {
                                        "CON", "PRN", "AUX", "CLOCK$", "NUL", "COM0", "COM1", "COM2", "COM3", "COM4",
                                        "COM5", "COM6", "COM7", "COM8", "COM9", "LPT0", "LPT1", "LPT2", "LPT3", "LPT4",
                                        "LPT5", "LPT6", "LPT7", "LPT8", "LPT9"
                                    };

            var sanitisedNamePart = Regex.Replace(filename, invalidReStr, "_");
            foreach (var reservedWord in reservedWords)
            {
                var reservedWordPattern = string.Format("^{0}\\.", reservedWord);
                sanitisedNamePart = Regex.Replace(sanitisedNamePart, reservedWordPattern, "_reservedWord_.", RegexOptions.IgnoreCase);
            }

            return sanitisedNamePart;
        }

        private void getPath()
        {
            var author = coerceValidFileName(txtAuthor.Text);
            var title = coerceValidFileName(txtTitle.Text);
            var path = Path.Combine(txtSaveToFolder.Text, author, title);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            _bookPath = path;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                setCurrentDisc(Convert.ToInt32(numStartWithDiscNumber.Value));
                getPath();
                while(!_done)
                {
                    if (promptForDisc())
                    {
                        rip();
                        pbTrackProgress.Value = 0;
                        pbTrackProgress.Refresh();
                        pbDiscProgress.Style = ProgressBarStyle.Marquee;
                        pbDiscProgress.Value = 0;
                        pbDiscProgress.Refresh();
                        encode();
                        pbTrackProgress.Value = 0;
                        pbTrackProgress.Refresh();
                        pbDiscProgress.Style = ProgressBarStyle.Continuous;
                        pbDiscProgress.Value = 0;
                        pbDiscProgress.Refresh();
                        setCurrentDisc(_currentDisc + 1);
                    }
                }
            }
        }

        private bool promptForDisc()
        {
            if(MessageBox.Show(this, string.Format("Please insert Disc {0} into the CDROM drive and click 'OK' to continue, or click 'Cancel' to stop ripping.", _currentDisc), string.Format("Disc {0}", _currentDisc), MessageBoxButtons.OKCancel, MessageBoxIcon.None) != DialogResult.OK)
            {
                _done = true;
                return false;
            }
            return true;
        }


        private void encode()
        {
            var wavFn = getFileName("wav");
            var mp3Fn = getFileName("mp3");
            using (var rdr = new WaveFileReader(wavFn))
            using (var wtr = new LameMP3FileWriter(mp3Fn, rdr.WaveFormat, LAMEPreset.V3, new ID3TagData
            {
                Artist = txtAuthor.Text,
                Album = txtTitle.Text,
                Track = Convert.ToString(_currentDisc),
                Title = string.Format("{0} Disc {1}", txtTitle.Text, Convert.ToString(_currentDisc))
            }))
            {
                rdr.CopyTo(wtr);
            }
            File.Delete(wavFn);
        }

        private string getFileName(string ext)
        {
            return string.Format("{0}\\Disc_{1}.{2}", _bookPath, _currentDisc, ext);
        }

        private void setCurrentTrack(int track)
        {
            _trackNum = track;
            lblTrackProgress.Text.Remove(0);
            lblTrackProgress.Text = string.Format("Track {0} of {1}", track, _discTracks);
            lblTrackProgress.Refresh();
        }

        private void setCurrentDisc(int disc)
        {
            _currentDisc = disc;
            lblDiscProgress.Text.Remove(0);
            lblDiscProgress.Text = string.Format("Disc {0}", disc);
            lblTrackProgress.Refresh();
        }

        private void rip()
        {
            pbTrackProgress.Value = 0;
            pbDiscProgress.Value = 0;
            pbDiscProgress.Style = ProgressBarStyle.Continuous;

            using (var drive = new CDDrive())
            {
                if (drive.Open(CDDrive.GetCDDriveLetters()[0]) && drive.IsCDReady() && drive.Refresh())
                {
                    _discTracks = drive.GetNumTracks();
                    byte[] buffer = new byte[4096];
                    drive.LockCD();
                    var format = new WaveLib.WaveFormat(44100, 16, 2);
                    var fs = new FileStream(getFileName("wav"), FileMode.Create, FileAccess.Write, FileShare.None);
                    try
                    {
                        _discLen = 0;
                        for (var i = 1; i <= _discTracks; i++)
                        {
                            _discLen += drive.TrackSize(i);
                        }
                        _discPos = 0;
                        _wr = new Yeti.MMedia.WaveWriter(fs, format);
                        for (var i = 1; i <= _discTracks; i++)
                        {
                            setCurrentTrack(i);
                            _trackLen = drive.TrackSize(i);
                            _trackPos = 0;
                            drive.ReadTrack(i, new CdDataReadEventHandler(WriteWavData), new CdReadProgressEventHandler(HandleProgress));
                        }
                    }
                    catch (Exception ex)
                    {
                        var result = MessageBox.Show(this, string.Format("{0}\n\n{1}", ex.Message, ex.StackTrace), "An unhandled error has occurred:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _done = true;
                    }
                    finally
                    {
                        _wr.Close();
                        fs.Close();
                        drive.UnLockCD();
                        drive.EjectCD();
                    }
                }
            }
        }

        private void WriteWavData(object sender, DataReadEventArgs e)
        {
            _trackPos += e.DataSize;
            _discPos += e.DataSize;

            var trackPct = Convert.ToInt32(Math.Round(((double)_trackPos / (double)_trackLen) * 100, 0));
            var discPct = Convert.ToInt32(Math.Round(((double)_discPos / (double)_discLen) * 100, 0));

            pbTrackProgress.Value = trackPct;
            pbDiscProgress.Value = discPct;

            if (_wr != null)
                _wr.Write(e.Data, 0, (int)e.DataSize);
        }

        private void HandleProgress(object sender, ReadProgressEventArgs e)
        {
            if(_cancel)
            {
                e.CancelRead = _cancel;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _cancel = true;
        }
    }
}
