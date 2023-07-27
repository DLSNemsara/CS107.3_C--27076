using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int number = int.Parse(Console.ReadLine());

            int tot = 0;

            while (number > 0)
            {
                int digit = number % 10;

                if (number % 2 == 1)
                {
                    tot += digit;
                }
                number /= 10;
            }

            Console.WriteLine("Sum of the Digit = {0}", tot);
            Console.ReadKey();
        }
    }
}
