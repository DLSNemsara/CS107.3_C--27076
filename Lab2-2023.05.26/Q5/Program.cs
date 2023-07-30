using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            Console.WriteLine("Enter the number: ");
            for (int i = 0; i<10; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (num[i] % 2 == 1)
                {
                    Console.WriteLine(+num[i]+ " is an odd number");
                }
                else
                    Console.WriteLine(+num[i]+ " is an even number");
            }
            Console.ReadKey();


        }
    }
}
