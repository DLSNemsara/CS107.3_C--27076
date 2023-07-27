using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter number 1: ");
                num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2:");
                num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.Write("Summation = " + sum);

            Console.ReadKey();
        }
    }
}
