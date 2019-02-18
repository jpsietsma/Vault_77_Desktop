using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLinkSmartDevices.Devices;

namespace Vault_77_Desktop.SDNLibraries
{

    /// <summary>
    /// Class that handles Vault 77 TP-Link Smart Plug devices
    /// </summary>
    public class SDNSmartPlugLibrary : TPLinkSmartPlug
    {
        public string HostName { get; set; }
        new public int Port { get; set; } = 9999;
        bool IsTurnedOn { get; set; }


        public SDNSmartPlugLibrary(string hostName = "") : base(hostName)
        {
            this.HostName = hostName;
        }

        /// <summary>
        /// Determine if the device is currently on or off
        /// </summary>
        /// <returns>True if powered on, false if not.</returns>
        private bool IsPoweredOn()
        {
            if (this.IsTurnedOn)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Turn on SDN Smart Plug
        /// </summary>
        /// <returns>true if successful</returns>
        private bool PowerOnDevice()
        {
            if (this.IsPoweredOn())
            {
                return true;
            }
            else
            {
                var plug = new TPLinkSmartPlug(this.HostName)
                {
                    OutletPowered = true
                    
                };
                this.IsTurnedOn = true;

                return true;
            }

        }

    }
}
