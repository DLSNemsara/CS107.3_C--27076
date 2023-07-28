using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Q4
{
    /*It cannot be accessed because private method of another class
    cannot be directly accessed from the main class*/
    /*private method is need to be changed to a public method to get an output
     * in this program*/
    internal class Program
    {

        static void Main()
        {
            GreetClass greeter = new GreetClass();

            // Try to access the SayHello method (This line will produce a compilation error)
            greeter.SayHello();

            Console.ReadLine();
        }
    }

    class GreetClass
    {
        private void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
