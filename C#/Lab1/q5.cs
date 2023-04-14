using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // Single inheritance
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Students : Person
    {
        public int Id { get; set; }
        public double GPA { get; set; }
    }

    // Multilevel inheritance
    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public double Salary { get; set; }
    }

    public class Manager : Employee
    {
        public string Department { get; set; }
    }

    // Hierarchical inheritance
    public class Teacher : Person
    {
        public string Subject { get; set; }
    }

    public class Professor : Person
    {
        public string Department { get; set; }
    }

    // Multiple inheritance using interface
    public interface IEmployee
    {
        int EmployeeId { get; set; }
        double Salary { get; set; }
    }

    public interface IStudent
    {
        int Id { get; set; }
        double GPA { get; set; }
    }

    public class Staff : IEmployee, IStudent
    {
        public int EmployeeId { get; set; }
        public double Salary { get; set; }
        public int Id { get; set; }
        public double GPA { get; set; }
    }

    public class Program4
    {
        public static void Main()
        {
            // Single inheritance example
            Students student = new Students { Name = "prakash", Age = 23, Id = 191826, GPA = 3.7 };
            Console.WriteLine("Student Name: " + student.Name);
            Console.WriteLine("Student Age: " + student.Age);
            Console.WriteLine("Student ID: " + student.Id);
            Console.WriteLine("Student GPA: " + student.GPA);

            // Multilevel inheritance example
            Manager manager = new Manager { Name = "Hari", Age = 35, EmployeeId = 191835, Salary = 50000, Department = "Finance" };
            Console.WriteLine("\nManager Name: " + manager.Name);
            Console.WriteLine("Manager Age: " + manager.Age);
            Console.WriteLine("Manager Employee ID: " + manager.EmployeeId);
            Console.WriteLine("Manager Salary: " + manager.Salary);
            Console.WriteLine("Manager Department: " + manager.Department);

            // Hierarchical inheritance example
            Teacher teacher = new Teacher { Name = "Hira", Age = 40, Subject = "Math" };
            Console.WriteLine("\nTeacher Name: " + teacher.Name);
            Console.WriteLine("Teacher Age: " + teacher.Age);
            Console.WriteLine("Teacher Subject: " + teacher.Subject);

            Professor professor = new Professor { Name = "Mahesh", Age = 50, Department = "R & D" };
            Console.WriteLine("\nProfessor Name: " + professor.Name);
            Console.WriteLine("Professor Age: " + professor.Age);
            Console.WriteLine("Professor Department: " + professor.Department);

            // Multiple inheritance using interface example
            Staff staff = new Staff { EmployeeId = 191822, Salary = 40000, Id = 200, GPA = 3.25 };
            Console.WriteLine("\nStaff Employee ID: " + staff.EmployeeId);
            Console.WriteLine("Staff Salary: " + staff.Salary);
            Console.WriteLine("Staff ID: " + staff.Id);
            Console.WriteLine("Staff GPA: " + staff.GPA);
        }
    }

}
