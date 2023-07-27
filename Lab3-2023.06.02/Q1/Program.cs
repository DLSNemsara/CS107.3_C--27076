using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.Write("Enter a number:");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 1)
            {
                Console.Write(+num1 + " is a odd number");
            }
            else
            {
                Console.Write(+num1 + " is an even number");
            }
            Console.ReadKey();
        }
    }
}
