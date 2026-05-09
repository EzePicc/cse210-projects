using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade (%)? ");
        string input = Console.ReadLine();
        int grade_percent = int.Parse(input);

        string letter = "";
        if (grade_percent >= 90)
        {
            letter = "A";
        }
        else if (grade_percent >= 80)
        {
            letter = "B";
        }
        else if (grade_percent >= 70)
        {
            letter = "C";
        }
        else if (grade_percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");
    }
}