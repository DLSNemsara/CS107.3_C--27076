using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter a value for number 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a value for number 2: ");
            num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.Write("Sum: " + sum);

            Console.ReadKey();
        }
    }
}
