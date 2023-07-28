using System;

class Program
{
    static void Main()
    {
        // Create an object of the ConvertValues class
        ConvertValues converter = new ConvertValues();

        // Get the user input for kilometers
        Console.Write("Enter the distance in kilometers (km): ");
        if (double.TryParse(Console.ReadLine(), out double kilometers))
        {
            // Call the kilometerToMeter method with the user input value
            double meters = converter.KilometerToMeter(kilometers);
            Console.WriteLine($"The distance in meters (m) is: {meters} m");
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
    public double KilometerToMeter(double kilometers)
    {
        double meters = kilometers * 1000;
        return meters;
    }
}
