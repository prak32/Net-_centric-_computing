using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    class Calculator
    {
        private double num1;
        private double num2;

        public Calculator(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double Add()
        {
            return num1 + num2;
        }

        public double Subtract()
        {
            return num1 - num2;
        }

        public double Multiply()
        {
            return num1 * num2;
        }

        public double Divide()
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = double.Parse(Console.ReadLine());

            Calculator calculator = new Calculator(num1, num2);

            Console.WriteLine("Addition: " + calculator.Add());
            Console.WriteLine("Subtraction: " + calculator.Subtract());
            Console.WriteLine("Multiplication: " + calculator.Multiply());

            try
            {
                Console.WriteLine("Division: " + calculator.Divide());
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }

}
