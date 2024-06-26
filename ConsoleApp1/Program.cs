﻿
class Program
{
    static void Main()
    {
        Console.Write("Enter a number between 0 and 100 for your grade: ");
        string input = Console.ReadLine();

        int grade;
        bool isValid = int.TryParse(input, out grade);

        if (isValid && grade >= 0 && grade <= 100)
        {
            string letterGrade = GetLetterGrade(grade);

            Console.WriteLine("Your respective grade is: " + letterGrade);
        }
        else
        {
            Console.WriteLine("Please enter a valid number between 0 and 100.");
        }
    }

    static string GetLetterGrade(int grade)
    {
        if (grade >= 90)
        {
            return "A";
        }
        else if (grade >= 80)
        {
            return "B";
        }
        else if (grade >= 70)
        {
            return "C";
        }
        else if (grade >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}