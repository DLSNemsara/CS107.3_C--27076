using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter number 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            int remainder = num2 - num1;
            double product = num1 * num2;
            double divison = num2 / num1;

            Console.Write("Sum is equal to " + sum);
            Console.Write("\nRemainder is equal to " + remainder);
            Console.Write("\nProduct is equal to " + product);
            Console.Write("\nDivision is equal to " + divison);

            Console.ReadKey();
        }
    }
}
