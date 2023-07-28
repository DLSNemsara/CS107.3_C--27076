using System;

class Program
{
    static void Main()
    {
        // Create an object of the ConvertValues class
        ConvertValues converter = new ConvertValues();

        // Call the kilometerTOmeter method
        converter.KilometerToMeter();

        Console.ReadLine();
    }
}

class ConvertValues
{
    public void KilometerToMeter()
    {
        Console.Write("Enter the distance in kilometers (km): ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double kilometers))
        {
            double meters = kilometers * 1000;
            Console.WriteLine($"The distance in meters (m) is: {meters} m");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric value for kilometers.");
        }
    }
}
