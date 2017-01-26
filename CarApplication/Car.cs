using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        // properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDice { get; set; }
        public int DoorCount { get; set; }
        public static int Wheels { get; set; }

        //default constructor
        public Car()
        {

        }
        // param constructor...
        public Car(string model)
        {
            Model = model;
        }
        

        // method to speed up
        public void Accelerate()
        {
            Speed += 10;
        }

        // method to slow down
        public void Break(int value)
        {
            Speed -= value;
        }

        // method to display car data
        public void PrintData()
        {
            Console.WriteLine("Car Properties: ");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine : " + Engine);
            Console.WriteLine("- door count : " + DoorCount);
            Console.WriteLine("- wheels : " + Wheels);
        }
        // desructor
        ~Car()
        {
            Console.WriteLine("Car object destroyed!");
        }
    }
}
