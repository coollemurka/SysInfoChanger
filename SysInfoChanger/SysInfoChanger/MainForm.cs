using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SysInfoChanger
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            _initProc();
        }

        private SIC.Processor proc;
        private SIC.HardDisk ssd;
        private string plOpenedName = "";

        private void _initProc()
        {
            proc = new SIC.Processor();
            plProc.tbName.Text = proc.Name;
            plProc.lbCores.Text += proc.Threads;
            plProc.lbMHz.Text += proc.MHz / 1000.0;
        }

        private void ltExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btpl_Click(object sender, EventArgs e)
        {
            _changePanel((sender as Control).Tag as string);
        }

        private void _changePanel(string plChangeName)
        {
            switch (plChangeName)
            {
                case "proc":
                    lbDeviceName.Text = "Processor(CP)";
                    plOpenedName = plChangeName;
                    if (plProc.Visible)
                    {
                        btSave.Visible = plProc.Visible = plSSD.Visible = false;
                    }
                    else
                    {
                        plSSD.Visible = false;
                        btSave.Visible = plProc.Visible = true;
                    }
                    break;
                case "ssd":
                    lbDeviceName.Text = "SSD";
                    plOpenedName = plChangeName;
                    if (plSSD.Visible)
                    {
                        btSave.Visible = plProc.Visible = plSSD.Visible = false;
                    }
                    else
                    {
                        plProc.Visible = false;
                        btSave.Visible = plSSD.Visible = true;
                    }
                    break;
                //case "ram":
                default:
                    lbDeviceName.Text = "Device";
                    //plRAM.Hide();
                    btSave.Visible = plProc.Visible = plSSD.Visible = false;
                    break;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            switch (plOpenedName)
            {
                case "proc":
                    proc.Name = plProc.tbName.Text;
                    break;
                case "ssd":
                    ssd = new SIC.HardDisk(plSSD.Path, plSSD.Quota);
                    if (ssd.Mount(string.Empty, plSSD.Letter)) MessageBox.Show("Done"); else MessageBox.Show("Already Mounted");
                    break;
            }
        }

    }
}
