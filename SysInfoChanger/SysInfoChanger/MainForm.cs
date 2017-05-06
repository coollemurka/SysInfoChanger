using System;
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

        private void btCP_Click(object sender, EventArgs e)
        {
            _changePanel("proc");
        }

        private void _changePanel(string plChnageName)
        {
            switch(plChnageName)
            {
                case "proc":
                    plOpenedName = plChnageName;
                    if (plProc.Visible)
                    {
                        plProc.Hide();
                        btSave.Hide();
                    }
                    else
                    {
                        plProc.Show();
                        btSave.Show();
                    }
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
            }
        }
    }
}
