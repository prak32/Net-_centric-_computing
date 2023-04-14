using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Student
    {
        private int id;
        private string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    public class Program1
    {
        public static void Main()
        {
            Student student = new Student();
            student.Id = 191826;
            student.Name = "Prakash Shrestha";
            Console.WriteLine("Student Id: " + student.Id);
            Console.WriteLine("Student Name: " + student.Name);
        }
    }
}
