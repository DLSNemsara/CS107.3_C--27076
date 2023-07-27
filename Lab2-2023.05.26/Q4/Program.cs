using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1%2 == 1) 
            {
                Console.WriteLine(+num1 + " is a Odd number");
            }
            else
            {
                Console.WriteLine(+num1 + " is an even number");
            }

            Console.ReadKey();
        }
    }
}
