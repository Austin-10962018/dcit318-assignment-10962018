using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter your age: ");
        int age = GetValidAge();

        double ticketPrice = CalculateTicketPrice(age);

        Console.WriteLine("The ticket price is: GHC" + ticketPrice);
    }

    static int GetValidAge()
    {
        int age;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out age) && age >= 0)
            {
                return age;
            }
            else
            {
                Console.Write("Invalid input. Please enter a valid age: ");
            }
        }
    }

    static double CalculateTicketPrice(int age)
    {
        const double regularPrice = 10.0;
        const double discountedPrice = 7.0;

        if (age <= 12 || age >= 65)
        {
            return discountedPrice;
        }
        else
        {
            return regularPrice;
        }
    }
}
