using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = -1 ;
        Random randomGenerator =new Random();
        int magic_num =randomGenerator.Next(1,100);
        
        while (guess != magic_num)
        {
            Console.Write("What is your guess ");
            guess =int.Parse(Console.ReadLine());

            if (guess < magic_num)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic_num)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}