using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    delegate int AddDelegate(int a, int b);

    class Program1
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            AddDelegate addDelegate = new AddDelegate(Add);

            Console.WriteLine("Enter first digit:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second digit:");
            int b = int.Parse(Console.ReadLine());

            int result = addDelegate(a, b);

            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, result);

            Console.ReadLine();
        }
    }

}
