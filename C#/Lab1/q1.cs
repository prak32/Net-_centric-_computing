using System;

class AddTwoDigits
{
    int num1, num2, sum;

    public AddTwoDigits(int n1, int n2)
    {
        num1 = n1;
        num2 = n2;
        sum = AddDigits(num1, num2);
    }

    public int AddDigits(int num1, int num2)
    {
        while (num2 != 0)
        {
            int carry = num1 & num2;
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

        AddTwoDigits add = new AddTwoDigits(num1, num2);
        add.DisplaySum();

        Console.ReadKey();
    }
}
