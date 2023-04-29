using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluetooth_test
{
    public class BatteryBluetoothConfig
    {
        public bool BatterySaverMode { get; set; }
        public bool BluetoothEnabled { get; set; }
        public string BluetoothDeviceName { get; set; }
        public string LicenseKey { get; set; }
        public string AppVersion { get; set; }
        public string Languages { get; set; }
    }
}
