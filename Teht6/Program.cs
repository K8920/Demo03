using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    class Program
    {
        static void Main(string[] args)
        {
           Switch switch1 = new Switch();
           int switchcase = 0;
            switch1.Model = "123-345-123";
            switch1.Manufacturer = "zyxel";
            Console.WriteLine("-----------------------");
            switch1.PrintData();
           switch1.PowerLed();
           Console.WriteLine("Press 1 to turn power on");
           Console.WriteLine("Press 2 to plug in the cable");
           Console.WriteLine("Press 3 to check internet connection");
            Console.WriteLine("Press 7 to exit");

            while (switchcase != 7)
            {
                string line1 = Console.ReadLine();
                switchcase = int.Parse(line1);

                switch (switchcase)
                {
                    case 1:
                        switch1.Power = true;
                        switch1.PowerLed();
                        break;

                    case 3:
                        switch1.LanLed();
                        break;

                    case 2:
                        switch1.Cable = true;
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Cable plugged in");
                        Console.WriteLine("-----------------------");
                        break;
                }
            }
        }
    }
}