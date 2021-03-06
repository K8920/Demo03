﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public string Name { get; set;}
        public int Speed { get; set;}
        public int Tyres { get; set;}

        public void PrintData()
        {
            Console.WriteLine("Car name: " + Name);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Tyres: " + Tyres);
        }

        public string ToString()
        {
            return (Name + Speed + Tyres);
        }
    }
}
