using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                ArrayManipulator manipulator = new ArrayManipulator();

                manipulator.ProcessArray(size);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the array size.");
            }

            Console.ReadLine();
        }

    }

    class ArrayManipulator
    {
        public void ProcessArray(int size)
        {
            int[] array = new int[size * 2]; 

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    array[i * 2] = input;
                    array[i * 2 + 1] = 0;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid numeric value.");
                    i--; 
                }
            }

            Console.WriteLine("Array values:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
