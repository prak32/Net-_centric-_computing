using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program4
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }

}
