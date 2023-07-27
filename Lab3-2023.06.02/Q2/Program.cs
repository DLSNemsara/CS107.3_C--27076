using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.Write("Enter a string: ");
            str = Console.ReadLine();

            int vowelCount = 0;
            for (int i = 0; i< str.Length; i++)
            {
                char ch = str[i];

                if (ch == 'a' ||  ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    vowelCount++;
                }
            }

            Console.Write("\nThe number of vowels in this string is {0}.", vowelCount);

            Console.ReadKey();
        }
    }
}
