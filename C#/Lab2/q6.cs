using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program6
    {
        static void Main(string[] args)
        {
            string[] names = { "Ram", "Shyam", "Hari", "Bikash", "Mahesh" };

            // Sort the names using a lambda expression
            Array.Sort(names, (n1, n2) => n1.CompareTo(n2));

            Console.WriteLine("Sorted names using lambda expression:");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Sort the names using LINQ
            var sortedNames = from name in names
                              orderby name
                              select name;

            Console.WriteLine("\nSorted names using LINQ:");

            foreach (string name in sortedNames)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }

}
