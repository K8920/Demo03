using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Pekka";
            student1.Age = 22;
            student1.Grade = 3;
            student1.Motivation = true;

            Student student2 = new Student();
            student2.Name = "Jorma";
            student2.Age = 29;
            student2.Grade = 2;
            student2.Motivation = false;

            Student student3 = new Student();
            student3.Name = "Jokke";
            student3.Age = 25;
            student3.Grade = 5;
            student3.Motivation = true;
            

            Student student4 = new Student();
            student4.Name = "Teppo";
            student4.Age = 25;
            student4.Grade = 4;
            student4.Motivation = true;

            Student student5 = new Student();
            student5.Name = "Danny";
            student5.Age = 18;
            student5.Grade = 1;
            student5.Motivation = false;

            Student[] Students = { student1, student2, student3, student4, student5 };
            foreach (Student s in Students)s.PrintData();
        }
    }
}