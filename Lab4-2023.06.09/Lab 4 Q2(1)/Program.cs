using System;

class Program
{
    static void Main()
    {
        FindValues calculator = new FindValues();

        Console.Write("Enter the radius of the circle: ");
        if (double.TryParse(Console.ReadLine(), out double radius))
        {
            double area = calculator.FindArea(radius);
            double circumference = calculator.FindCircumference(radius);

            Console.WriteLine($"Area of the circle: {area}");
            Console.WriteLine($"Circumference of the circle: {circumference}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric value for the radius.");
        }

        Console.ReadLine();
    }
}

class FindValues
{
    public double FindArea(double radius)
    {
        return 3.14 * radius * radius;
    }

    public double FindCircumference(double radius)
    {
        return 2 * 3.14 * radius;
    }
}
