using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SysInfoChanger
{
    public partial class SSD : UserControl
    {
        public SSD()
        {
            InitializeComponent();
            string _formattedPath = _path;
            if (_formattedPath.Length > 30) _formattedPath = $"...{_formattedPath.Substring(_formattedPath.Length - 30, 30)}";
            lbPath.Text = _formattedPath;
            UpdateLetters();
        }

        public string Path
        {
            get
            {
                return _path;
            }
        }

        public int Quota
        {
            get
            {
                return _quota;
            }
        }

        public string Letter
        {
            get
            {
                return alphabet[dudLetter.SelectedIndex];
            }
        }

        private int _quota = 500;

        private string _path = Application.StartupPath;

        private void btFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = _fbd;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                _path = fbd.SelectedPath;
                string _formattedPath = _path;
                if (_formattedPath.Length > 30) _formattedPath = $"...{_formattedPath.Substring(_formattedPath.Length - 30, 30)}";
                lbPath.Text = _formattedPath;
            }
        }

        private void bsSize_ValueChanged(object sender, EventArgs e)
        {
            _quota = bsSize.Value;
            lbSize.Text = $"{Math.Round(_quota / 1000.0, 2)} TB";
        }


        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public void UpdateLetters()
        {
            dudLetter.Items.Clear();
            for (int i = 0; i < alphabet.Length; ++i)
            {
                if (DriveInfo.GetDrives().Any(x => x.Name != alphabet[i].ToUpper() || x.Name != alphabet[i].ToLower()))
                {
                    dudLetter.Items.Add($@"{alphabet[i]}:\");
                }
            }
            dudLetter.SelectedIndex = alphabet.Length - 1;
        }
    }
}
