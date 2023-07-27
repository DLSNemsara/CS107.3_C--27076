using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;

            Console.Write("Enter the radius: ");
            radius = double.Parse(Console.ReadLine());

            double area;
            double circumference;

            area = 3.14 * radius * radius;
            circumference = 2*3.14* radius;

            Console.Write("Area = " + area);
            Console.Write("\nCircumference = " + circumference);

            Console.ReadKey();

        }
    }
}
