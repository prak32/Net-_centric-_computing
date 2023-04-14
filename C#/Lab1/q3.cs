using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Program2
    {
        public static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int length = array.Length;

            // Loop through the array up to half its length
            for (int i = 0; i < length / 2; i++)
            {
                // Swap the i-th element from the beginning with the i-th element from the end
                int temp = array[i];
                array[i] = array[length - i - 1];
                array[length - i - 1] = temp;
            }

            // Display the reversed array
            Console.WriteLine("Reversed Array:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }
    }

}
