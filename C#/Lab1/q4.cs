using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class StudentList
    {
        private string[] names;

        public StudentList(int size)
        {
            names = new string[size];
        }

        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
    }

    public class Program3
    {
        public static void Main()
        {
            StudentList students = new StudentList(5);

            // Store names of students
            students[0] = "prakash";
            students[1] = "Nikhil";
            students[2] = "Rochak";
            students[3] = "Archana";
            students[4] = "Kritika";

            // Retrieve names of students
            Console.WriteLine("Names of Students:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
