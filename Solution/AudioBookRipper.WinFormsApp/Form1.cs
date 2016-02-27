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

namespace AudioBookRipper.WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
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
    }
}
