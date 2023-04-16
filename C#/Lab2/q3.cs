using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    interface IArithmetic
    {
        double Add(double num1, double num2);
        double Subtract(double num1, double num2);
        double Multiply(double num1, double num2);
        double Divide(double num1, double num2);
    }

    class Calculators : IArithmetic
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = double.Parse(Console.ReadLine());

            Calculators calculator = new Calculators();

            Console.WriteLine("Addition: " + calculator.Add(num1, num2));
            Console.WriteLine("Subtraction: " + calculator.Subtract(num1, num2));
            Console.WriteLine("Multiplication: " + calculator.Multiply(num1, num2));

            try
            {
                Console.WriteLine("Division: " + calculator.Divide(num1, num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }

}
