using System;
using Figure002;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a feature:");
        Console.WriteLine("0: Exit");
        Console.WriteLine("1: Area of Circle");
        Console.WriteLine("2: Perimeter of Circle");
        Console.WriteLine("3: Area of Triangle");
        Console.WriteLine("4: Perimeter of Triangle");
        Console.WriteLine("5: Area of Rectangle");
        Console.WriteLine("6: Perimeter of Rectangle");

        int featureChoice = ReadInt32("Enter your choice: ");

        switch (featureChoice)
        {
            case 0:
                Console.WriteLine("Exiting the program.");
                return;
            case 1:
                CalculateCircleArea();
                break;
            case 2:
                CalculateCirclePerimeter();
                break;
            case 3:
                CalculateTriangleArea();
                break;
            case 4:
                CalculateTrianglePerimeter();
                break;
            case 5:
                CalculateRectangleArea();
                break;
            case 6:
                CalculateRectanglePerimeter();
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose from the available options.");
                break;
        }
    }

    private static void CalculateCircleArea()
    {
        Console.WriteLine("Enter the radius of the circle:");
        double radius = ReadDouble("Radius: ");

        Circle circle = new Circle(radius);
        double area = circle.Area();

        Console.WriteLine($"The area of the circle is: {area}");
    }

    private static void CalculateCirclePerimeter()
    {
        Console.WriteLine("Enter the radius of the circle:");
        double radius = ReadDouble("Radius: ");
        Circle circle = new Circle(radius);
        double perimeter = circle.Perimeter();
        Console.WriteLine($"The perimeter of the circle is: {perimeter}");
    }

    private static void CalculateTriangleArea()
    {
        Console.WriteLine("Enter the length of side 1 of the triangle:");
        double side1 = ReadDouble("Side 1: ");

        Console.WriteLine("Enter the length of side 2 of the triangle:");
        double side2 = ReadDouble("Side 2: ");

        Console.WriteLine("Enter the length of side 3 of the triangle:");
        double side3 = ReadDouble("Side 3: ");

        Triangle triangle = new Triangle(side1, side2, side3);
        double area = triangle.Area();

        Console.WriteLine($"The area of the triangle is: {area}");
    }

    private static void CalculateTrianglePerimeter()
    {
        Console.WriteLine("Enter the length of side 1 of the triangle:");
        double side1 = ReadDouble("Side 1: ");

        Console.WriteLine("Enter the length of side 2 of the triangle:");
        double side2 = ReadDouble("Side 2: ");

        Console.WriteLine("Enter the length of side 3 of the triangle:");
        double side3 = ReadDouble("Side 3: ");

        Triangle triangle = new Triangle(side1, side2, side3);
        double perimeter = triangle.Perimeter();
        Console.WriteLine($"The perimeter of the triangle is: {perimeter}");
    }
    private static void CalculateRectangleArea()
    {
        Console.WriteLine("Enter the length of the rectangle:");
        double length = ReadDouble("Length: ");

        Console.WriteLine("Enter the width of the rectangle:");
        double width = ReadDouble("Width: ");

        Rectangle rectangle = new Rectangle(length, width);
        double area = rectangle.Area();

        Console.WriteLine($"The area of the rectangle is: {area}");
    }

    private static void CalculateRectanglePerimeter()
    {
        Console.WriteLine("Enter the length of the rectangle:");
        double length = ReadDouble("Length: ");

        Console.WriteLine("Enter the width of the rectangle:");
        double width = ReadDouble("Width: ");

        Rectangle rectangle = new Rectangle(length, width);
        double perimeter = rectangle.Perimeter(); // Implement Perimeter() in Rectangle class

        Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
    }

    private static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            try
            {
                double value = Convert.ToDouble(input);
                return value;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    private static int ReadInt32(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            try
            {
                int value = Convert.ToInt32(input);
                return value;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
