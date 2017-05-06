using Microsoft.Win32;

namespace SIC
{
    public class Processor
    {
        public Processor()
        {
            _init();
        }

        /// <summary>
        /// Get MHz of processor
        /// </summary>
        public int MHz
        {
            get
            {
                return _mhz;
            }
        }

        /// <summary>
        /// Get the number of threads(cores)
        /// </summary>
        public int Threads
        {
            get
            {
                return _threads;
            }
        }

        /// <summary>
        /// Get and set name of processor
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _changeCPName(value);
            }
        }

        private int _mhz = 0;
        private int _threads = 0;
        private string _name = string.Empty;

        //Device Manager Central Processor
        private RegistryKey _dmcp;

        //About System Central Processor
        private RegistryKey _ascp;

        private void _init()
        {
            _loadDMCP();
            _loadASCP();
        }

        #region Utils
        private void _loadDMCP()
        {
            //Set CentralProcessor RegistryKey
            _dmcp = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor");

            //Set number of threads(cores)
            _threads = _dmcp.SubKeyCount;

            //Set MHz
            _mhz = (int)_dmcp.OpenSubKey("0").GetValue("~MHz");
        }

        private void _loadASCP()
        {
            RegistryKey _acpi = Registry.LocalMachine.OpenSubKey(@"SYSTEM\ControlSet001\Enum\ACPI");

            //Check all devices in ACPI
            foreach (string _acpiSubKeyName in _acpi.GetSubKeyNames())
            {
                RegistryKey _acpiSubKey = _acpi.OpenSubKey(_acpiSubKeyName);

                //Check all devices in SubACPI
                foreach (string _acpiSubKeySubKeyName in _acpiSubKey.GetSubKeyNames())
                {
                    string[] CompatibleIDs = _acpiSubKey.OpenSubKey(_acpiSubKeySubKeyName).GetValue("CompatibleIDs") as string[];

                    //Check if _acpiSubKeySubKeyName is processor
                    if (CompatibleIDs != null && CompatibleIDs.Length == 1 && CompatibleIDs[0] == @"ACPI\Processor")
                    {
                        _ascp = _acpiSubKey;

                        //Don't need to rechange number of thread(cores)
                        //_threads = _aboutSystemCP.SubKeyCount;

                        //Set name of processor
                        _name = _acpiSubKey.OpenSubKey(_acpiSubKeySubKeyName).GetValue("FriendlyName") as string;

                        //Don't need to check other devices
                        return;
                    }
                }
            }
        }

        private void _changeCPName(string Name)
        {
            //Limit of REG_SZ
            if (Name.Length > 1000) Name = Name.Substring(0, 1000);

            //Chnage processor name in Device Manager(_dmcp)
            foreach (string _dmcpSubKeyName in _dmcp.GetSubKeyNames())
                _dmcp.OpenSubKey(_dmcpSubKeyName, true).SetValue("ProcessorNameString", Name);

            //Chnage processor name in About System(_ascp)
            foreach (string _ascpSubKeyName in _ascp.GetSubKeyNames())
                _ascp.OpenSubKey(_ascpSubKeyName, true).SetValue("FriendlyName", Name);
        }
        #endregion
    }
}
