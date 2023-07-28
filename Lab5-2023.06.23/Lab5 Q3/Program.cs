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
                CalculateValues calculator = new CalculateValues();

                Console.WriteLine("Enter 1 for addition");
                Console.WriteLine("Enter 2 for subtraction");
                Console.WriteLine("Enter 3 for multiplication");
                Console.WriteLine("Enter 4 for division");
                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.Write("Enter Number 1: ");
                    if (double.TryParse(Console.ReadLine(), out double num1))
                    {
                        Console.Write("Enter Number 2: ");
                        if (double.TryParse(Console.ReadLine(), out double num2))
                        {
                            double result;
                            switch (choice)
                            {
                                case 1:
                                    result = calculator.Addition(num1, num2);
                                    break;
                                case 2:
                                    result = calculator.Subtraction(num1, num2);
                                    break;
                                case 3:
                                    result = calculator.Multiplication(num1, num2);
                                    break;
                                case 4:
                                    result = calculator.Division(num1, num2);
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice. Please enter a valid option (1-4).");
                                    return;
                            }

                            Console.WriteLine($"Your answer is: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for Number 2. Please enter a valid numeric value.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for Number 1. Please enter a valid numeric value.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-4).");
                }

                Console.ReadLine();
            }
        }

        class CalculateValues
        {
            public double Addition(double num1, double num2)
            {
                return num1 + num2;
            }

            public double Subtraction(double num1, double num2)
            {
                return num1 - num2;
            }

            public double Multiplication(double num1, double num2)
            {
                return num1 * num2;
            }

            public double Division(double num1, double num2)
            {
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    return double.NaN;
                }
            }
        }

    }
