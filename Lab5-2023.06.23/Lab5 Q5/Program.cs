using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    numbers[i] = num;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid numeric value.");
                    i--; 
                }
            }

            ArrayOperations arrayOps = new ArrayOperations();

            arrayOps.CalculateArrayStats(numbers);

            Console.ReadLine();
        }
    }

    class ArrayOperations
    {
        public void CalculateArrayStats(int[] arr)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;

            // Calculate minimum, maximum, and sum of the array elements
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];

                sum += arr[i];
            }

            // Calculate average
            double average = (double)sum / arr.Length;

            // Print the results
            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Average value: {average}");

            // Reverse the array and print it
            Array.Reverse(arr);
            Console.WriteLine("Reversed order of values:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

}

