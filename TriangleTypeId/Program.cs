using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the length of the 1st side: ");
        double side1 = GetPositiveDouble();

        Console.Write("Enter the length of the 2nd side: ");
        double side2 = GetPositiveDouble();

        Console.Write("Enter the length of the 3rd side: ");
        double side3 = GetPositiveDouble();

        string triangleType = GetTriangleType(side1, side2, side3);

        Console.WriteLine("This means your triangle is a/an " + triangleType +" triangle.");
    }

    static double GetPositiveDouble()
    {
        double result;
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out result) && result > 0)
            {
                return result;
            }
            else
            {
                Console.Write("Invalid input. Please enter a positive number: ");
            }
        }
    }

    static string GetTriangleType(double side1, double side2, double side3)
    {
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}