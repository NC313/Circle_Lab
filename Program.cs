namespace Circle_Lab;

using System;

class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateDiameter()
    {
        return 2 * radius;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public void Grow()
    {
        radius *= 2;
    }

    public double GetRadius()
    {
        return radius;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Circle Tester");

        double radius;
        Circle circle;

        while (true)
        {
            Console.Write("Enter radius: ");
            if (double.TryParse(Console.ReadLine(), out radius) && radius > 0)
            {
                circle = new Circle(radius);
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive numeric value for the radius.");
            }
        }

        DisplayCircleInfo(circle);

        while (true)
        {
            Console.Write("Should the circle grow? (y/n): ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "y")
            {
                circle.Grow();
                DisplayCircleInfo(circle);
            }
            else if (input == "n")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'y' for yes or 'n' for no.");
            }
        }

        Console.WriteLine($"Goodbye. The circle's final radius is {circle.GetRadius()}");
    }

    static void DisplayCircleInfo(Circle circle)
    {
        Console.WriteLine("Diameter: " + circle.CalculateDiameter());
        Console.WriteLine("Circumference: " + circle.CalculateCircumference().ToString("F3"));
        Console.WriteLine("Area: " + circle.CalculateArea().ToString("F4"));
    }
}
