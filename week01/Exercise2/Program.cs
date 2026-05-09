using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade (%)? ");
        string input = Console.ReadLine();
        int grade_percent = int.Parse(input);

        if (grade_percent >= 90)
        {
            Console.WriteLine("Your grade is A");
            Console.WriteLine("Great job! You passed the course");
        }
        else if (grade_percent >= 80)
        {
            Console.WriteLine("Your grade is B");
            Console.WriteLine("Great job! You passed the course");
        }
        else if (grade_percent >= 70)
        {
            Console.WriteLine("Your grade is C");
            Console.WriteLine("Good job! You passed the course");
        }
        else if (grade_percent >= 60)
        {
            Console.WriteLine("Your grade is D");
            Console.WriteLine("Good job! You passed the course");
        }
        else
        {
            Console.WriteLine("Your grade is F");
            Console.WriteLine("You didn't pass the course. You can do it next time!");
        }
    }
}