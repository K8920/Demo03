using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public string Name;
        public int Age;
        public int Grade;
        public bool Motivation = false;

        public void Studying()
        {
            if (Motivation == true)
            {
                Console.WriteLine("Student is studying and is happy");
                Console.WriteLine("Grades going up");
            }
        }
        public void Rage()
        {
            if (Motivation == false)
            {
                Console.WriteLine("Student is not studying and is questioning meaning of life");
                Console.WriteLine("Grades going down");
            }
        }
        public void PrintData()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Student name: " + Name);
            Console.WriteLine("Student Age: " + Age);
            Rage();
            Studying();
            Console.WriteLine("Student Grade: " + Grade);
            Console.WriteLine("Student Motivation: " + Motivation);
        }
    }
}
