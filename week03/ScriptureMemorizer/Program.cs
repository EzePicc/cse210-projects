//creativity and exceeds core requirements: 
//The program counts the number of attempts the user takes to complete the scripture
using System;

class Program
{
    static void Main()
    {        
        Scripture scripture = new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life"
        );

        int attempts = 0;   
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\n");

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine($"Congratulations! You memorized the scripture in {attempts} attempts.");
                Console.ReadLine();
                break;
            }

            Console.Write("Press Enter or write 'quit': ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(5);
            attempts++;
        }
    }
}