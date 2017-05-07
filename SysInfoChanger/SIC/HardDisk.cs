using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIC
{
    public class HardDisk
    {
        public string Path;
        public int Quota;
        private Process _diskPart;

        public HardDisk(string Path, int Quota = 500)
        {
            this.Path = Path;
            this.Quota = Quota;
            _diskPart = _startDiskPart();
            if (File.Exists($@"{Path}\SIC.vhdx"))
            {
                try
                {
                    _diskPart.StandardInput.WriteLine($"select vdisk file = \"{Path}\\SIC.vhdx\"");
                    _diskPart.StandardInput.WriteLine("detach vdisk");
                    _diskPart.StandardInput.WriteLine("exit");
                    _diskPart.WaitForExit();
                    File.Delete($@"{Path}\SIC.vhdx");
                    _diskPart = _startDiskPart();
                }
                catch (Exception)
                {

                }
            }
        }

        public bool Mount(string Label = "", string Letter = "x")
        {
            if (Letter.Length != 1 || DriveInfo.GetDrives().Any(x => x.Name == Letter.ToUpper() || x.Name == Letter.ToLower())) return false;
            _diskPart.StandardInput.WriteLine($"create vdisk file=\"{Path}\\SIC.vhdx\" maximum={Quota * 1024} type=expandable");
            _diskPart.StandardInput.WriteLine("attach vdisk");
            _diskPart.StandardInput.WriteLine("create partition primary");
            _diskPart.StandardInput.WriteLine($"format fs=ntfs label=\"{Label}\" quick");
            _diskPart.StandardInput.WriteLine($"assign letter={Letter}");
            _diskPart.StandardInput.WriteLine("exit");
            _diskPart.WaitForExit();
            return true;
        }

        private Process _startDiskPart()
        {
            ProcessStartInfo processInfo = new ProcessStartInfo(@"C:\Windows\System32\diskpart.exe");
            processInfo.CreateNoWindow = processInfo.RedirectStandardError = processInfo.RedirectStandardInput = processInfo.RedirectStandardOutput = true;
            processInfo.UseShellExecute = false;
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            return Process.Start(processInfo);
        }
    }
}
