using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary;
            double tax;

            Console.WriteLine("Enter the salary of the employee: ");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the tax rate ");
            tax = Convert.ToDouble(Console.ReadLine());

            double salaryAfterTax = salary - (salary*tax);

            Console.WriteLine("Salary after tax: " +salaryAfterTax);

            Console.ReadKey();
        }
    }
}
