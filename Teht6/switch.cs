using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    class Switch
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public bool Power { get; set; }
        public bool Cable { get; set; }

        public void PowerLed()
        {
            if (Power == true)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Power is on");
                Console.WriteLine("-----------------------");
            }
            else
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Switch is off");
                Console.WriteLine("-----------------------");
            }
        }
        public void LanLed()
        {
            if (Power == true && Cable == true)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Lan led lights up");
                Console.WriteLine("You have internet connection!! You are the master of the universe !!");
                Console.WriteLine("-----------------------");
            }

            if (Power == false || Cable == false)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Something is wrong, please make sure that the switch is on and cable is plugged in");
                Console.WriteLine("-----------------------");
            }
        }
        public void PrintData()
        {
            Console.WriteLine(Model +" "+ Manufacturer);
        }
    }
}
