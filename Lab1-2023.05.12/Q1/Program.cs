using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            double batch;

            Console.Write("Enter your name:");
            name = Console.ReadLine();

            Console.Write("Enter your batch:");
            batch = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + batch);

            Console.ReadKey();
        }
    }
}
