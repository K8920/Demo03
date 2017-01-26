using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            WashingMachine washer = new WashingMachine();

            washer.Power = true;
            washer.Water = true;
            washer.Temperature = 50;
            washer.Time = 60;

            Console.WriteLine("Power: " + washer.Power);
            Console.WriteLine("Water: " + washer.Water);
            Console.WriteLine("Temperature: " + washer.Temperature);
            Console.WriteLine("Time remaining: " + washer.Time);
            Console.WriteLine();

            Console.WriteLine("Few minutes later....");
            Console.WriteLine("Washer is Slinging");
            washer.Sling();
        }
    }
}
