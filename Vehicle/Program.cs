using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Nissan";
            vehicle.Speed = 50;
            vehicle.Tyres = 4;
            vehicle.PrintData();
            Console.WriteLine("--------------------");
            vehicle.Name = "Toyota";
            vehicle.Speed = 70;
            vehicle.Tyres = 6;
            vehicle.PrintData();
            Console.WriteLine("--------------------");
  
        }
    }
}
