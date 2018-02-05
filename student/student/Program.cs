using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Student
    {
        public string fname;
        public string lname;
        public double gpa;

        public Student()
        {
            fname = Console.ReadLine();
            lname = Console.ReadLine();
            gpa = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return fname + " " + lname + " " + gpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
