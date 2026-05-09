using System;

class Program
{
    static void Main(string[] args)
    {
        Display_Welcome_mg();
        string username= Prompt_User_Name();
        int favorite_number = PromptUserNumber();
        int SquaredNumber= SquareNumber(favorite_number);
        Display_Result(username, SquaredNumber);
    }
    static void Display_Welcome_mg()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string Prompt_User_Name()
    {
        Console.Write("Please enter your name: ");
        string name =Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber (int number)
    {
        int square =number*number;
        return square;
    }
    static void Display_Result(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}