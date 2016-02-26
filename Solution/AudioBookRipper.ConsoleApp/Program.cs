using NAudio.Lame;
using NAudio.Wave;
using Ripper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveLib;
using Yeti.MMedia;


namespace AudioBookRipper.ConsoleApp
{
    class Program
    {
        static string _outFn;
        static string _wavFn;
        static LAMEPreset _quality;
        static string _artist;
        static string _album;
        static string _discNumber;

        static WaveWriter _wr;
        static int _trackNum;
        static uint _trackPos;
        static uint _trackLen;

        static void WriteRawData(object sender, DataReadEventArgs e)
        {
            _trackPos += e.DataSize;

            var pct = Math.Round(((double)_trackPos / (double)_trackLen) * 100, 0);

            Console.Write("\rTrack {0}: {1}%     ", _trackNum, pct);

            if(_wr != null)
            {
                _wr.Write(e.Data, 0, (int)e.DataSize);
            }
        }

        static void HandleProgress(object sender, EventArgs e)
        {
        }

        static LAMEPreset ParseLamePreset(string value)
        {
            LAMEPreset result;
            if (Enum.TryParse<LAMEPreset>(value, out result))
                return result;
            else
                return LAMEPreset.STANDARD;
        }

        static void Main(string[] args)
        {
            _outFn = args[0];
            _wavFn = _outFn.Replace(".mp3", ".wav");
            _quality = ParseLamePreset(args[1]);
            _artist = args[2];
            _album = args[3];
            _discNumber = args[4];

            Rip();
            Encode();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static void Rip()
        {
            CDDrive Drive;
            Drive = new CDDrive();
            if (Drive.Open(CDDrive.GetCDDriveLetters()[0]))
            {
                if (Drive.IsCDReady())
                {
                    if (Drive.Refresh())
                    {
                        int Tracks = Drive.GetNumTracks();
                        byte[] Buffer = new byte[4096];
                        Drive.LockCD();
                        var format = new WaveLib.WaveFormat(44100, 16, 2);

                        var fs = new FileStream(_wavFn, FileMode.Create, FileAccess.Write, FileShare.None);
                        try
                        {
                            var totalSize = default(uint);
                            for (int i = 1; i <= Tracks; i++)
                            {
                                totalSize += Drive.TrackSize(i);
                            }

                            Console.WriteLine("AudioBookRipper");
                            Console.Write("Ripping {0} Track(s), Total Size: {1} KB", Tracks, Math.Round((double)totalSize / (double)1024, 0));

                            _wr = new WaveWriter(fs, format);
                            for (int i = 1; i <= Tracks; i++)
                            {
                                _trackNum = i;
                                _trackLen = Drive.TrackSize(i);
                                _trackPos = 0;
                                Console.WriteLine();
                                Drive.ReadTrack(i, new CdDataReadEventHandler(WriteRawData), new CdReadProgressEventHandler(HandleProgress));
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                        }
                        finally
                        {
                            _wr.Close();
                            fs.Close();
                            Drive.UnLockCD();
                        }
                    }
                }
            }
        }

        static void Encode()
        {
            Console.WriteLine("\nEncoding to MP3");
            using (var rdr = new WaveFileReader(_wavFn))
            using (var wtr = new LameMP3FileWriter(_outFn, rdr.WaveFormat, LAMEPreset.V3, new ID3TagData
            {
                Artist = _artist,
                Album = _album,
                Track = _discNumber,
                Title = string.Format("Disc {0}", _discNumber)
            }))
            {
                rdr.CopyTo(wtr);
            }
        }
    }
}
