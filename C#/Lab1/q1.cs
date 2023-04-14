using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class AddTwoNumbers
    {
        int num1, num2, sum;

        public AddTwoNumbers(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
            sum = Add(num1, num2);
        }

        public int Add(int num1, int num2)
        {
            int carry;
            while (num2 != 0)
            {
                carry = num1 & num2;
                num1 = num1 ^ num2;
                num2 = carry << 1;
            }

            return num1;
        }

        public void DisplaySum()
        {
            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            AddTwoNumbers add = new AddTwoNumbers(num1, num2);
            add.DisplaySum();

            Console.ReadKey();
        }
    }

}
