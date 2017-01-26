using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Heater
    {
        // properties
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public double Humidity { get; set; }

        // methods
        public void ThrowWater()
        {
            Console.WriteLine("Shhhhhh.....");
        }
    }
}
