using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int number = int.Parse(Console.ReadLine());

            int tot = 0;

            for (; number > 0; number /= 10)
            {
                int digit = number % 10;
                tot += digit;
            }

            Console.WriteLine("Sum of the Digit = {0}", tot);
            Console.ReadKey();
        }
    }
}

