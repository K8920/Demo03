using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineApplication
{
    class WashingMachine
    {
        public bool Power { get; set; }
        public int Temperature { get; set; }
        public bool Water { get; set; }
        public double Time { get; set; }

        public void Washing()
        {
            Console.WriteLine("Surrrr....KlinkKlonk");
        }
        public void Sling()
        {
            Console.WriteLine("!!!!Surring intensifies!!!!");
        }
       
    }
}
