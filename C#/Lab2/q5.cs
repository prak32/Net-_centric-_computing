using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program5
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> customers = new Dictionary<int, string>();

            customers.Add(101, "Rame");
            customers.Add(102, "Shyame");
            customers.Add(103, "Gopale");
            customers.Add(104, "Nande");
            customers.Add(105, "Mangale");

            foreach (KeyValuePair<int, string> customer in customers)
            {
                Console.WriteLine("Customer ID: " + customer.Key + "  " + "Customer Name: " + customer.Value);
            }

            Console.ReadLine();
        }
    }

}
