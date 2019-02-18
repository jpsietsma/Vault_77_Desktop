using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLinkSmartDevices.Devices;

namespace Vault_77_Desktop.SDNLibraries
{
    public class SDNSmartBulbLibrary : TPLinkSmartBulb
    {
        public string HostName { get; set; }
        new public int Port { get; set; } = 9999;
        public bool IsPoweredOn { get; set; }

        public SDNSmartBulbLibrary(string hostName = "") : base(hostName)
        {
            this.HostName = hostName;
        }
    }
}
