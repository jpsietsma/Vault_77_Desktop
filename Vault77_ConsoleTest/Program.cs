using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLinkSmartDevices.Devices;

namespace Vault77_ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var smartPlug = new TPLinkSmartPlug("HS100");
            var smartBulb = new TPLinkSmartBulb("LB130");

            if (!smartBulb.PoweredOn == false)
            {
                //smartBulb.PoweredOn = false;
            }

            if (!smartPlug.OutletPowered == false)
            {
                //smartPlug.OutletPowered = false;
            }

                Console.WriteLine($@"Device Name: { smartBulb.Alias }");
                Console.WriteLine($@"Device Status: { smartBulb.PoweredOn }");
                Console.WriteLine();
                Console.WriteLine($@"Device Name: { smartPlug.Alias }");
                Console.WriteLine($@"Device Status: { smartPlug.OutletPowered }");
                Console.WriteLine();

            Console.ReadLine();

            if (!smartBulb.PoweredOn == true)
            {
                //smartBulb.PoweredOn = true;
            }

            if (!smartPlug.OutletPowered == true)
            {
                //smartPlug.OutletPowered = true;
            }

            Console.WriteLine($@"Device Name: { smartBulb.Alias }");
                Console.WriteLine($@"Device Status: { smartBulb.PoweredOn }");
                Console.WriteLine();
                Console.WriteLine($@"Device Name: { smartPlug.Alias }");
                Console.WriteLine($@"Device Status: { smartPlug.OutletPowered }");
                Console.WriteLine();
            
            Console.ReadLine();

        }
    }
}
