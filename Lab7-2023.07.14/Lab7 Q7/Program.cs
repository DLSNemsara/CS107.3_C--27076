using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Q6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the arrays: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];


            Console.WriteLine("Enter values for Array 1:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value for index {i}: ");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Enter values for Array 2:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value for index {i}: ");
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }


            int scalarSum = CalculateScalarSum(array1) + CalculateScalarSum(array2);
            Console.WriteLine($"Scalar Sum: {scalarSum}");


            int[] vectorSum = CalculateVectorSum(array1, array2);
            Console.WriteLine("\nVector Sum:");
            DisplayArray(vectorSum);


            int[] vectorProduct = CalculateVectorProduct(array1, array2);
            Console.WriteLine("\nVector Product:");
            DisplayArray(vectorProduct);


            int scalarProduct = CalculateScalarProduct(array1, array2);
            Console.WriteLine($" Scalar Product: {scalarProduct}");


            Console.ReadKey();
        }


        static int CalculateScalarSum(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }


        static int[] CalculateVectorSum(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }
            return result;
        }


        static int[] CalculateVectorProduct(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] * arr2[i];
            }
            return result;
        }


        static int CalculateScalarProduct(int[] arr1, int[] arr2)
        {
            int[] productArray = CalculateVectorProduct(arr1, arr2);
            return CalculateScalarSum(productArray);
        }


        static void DisplayArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
