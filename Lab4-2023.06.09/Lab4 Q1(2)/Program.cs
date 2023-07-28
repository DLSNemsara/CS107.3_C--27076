using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Q2
{
    class Program
    {
        static void Main()
        {
            ConvertValues converter = new ConvertValues();

            Console.Write("Enter the distance in kilometers (km): ");
            if (double.TryParse(Console.ReadLine(), out double kilometers))
            {
                converter.KilometerToMeter(kilometers);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value for kilometers.");
            }

            Console.ReadLine();
        }
    }

    class ConvertValues
    {
        public void KilometerToMeter(double kilometers)
        {
            double meters = kilometers * 1000;
            Console.WriteLine($"The distance in meters (m) is: {meters} m");
        }
    }
}
