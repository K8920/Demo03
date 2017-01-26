using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new instance from Car class
            Car car = new Car();
            car.Model = "Toyota AE86";
            car.Color = "Panda";
            car.Engine = 1.5;
            car.Speed = 80;
            car.FuzzyDice = true;
            car.DoorCount = 2;
            car.Accelerate();
            Car.Wheels = 4;
            car.PrintData();
            car.Break(7);
            car.PrintData();
            // create another car object
            string model = "Speedster";
            Car nascar = new Car(model);
            nascar.Color = "black";
            Console.WriteLine("Color is: " + nascar.Color);
            nascar.PrintData();
            
            
        }
    }
}
