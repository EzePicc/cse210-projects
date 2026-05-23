using System;

class Program
{
    static void Main()
    {        
        Scripture scripture = new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life"
        );

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\n");

            if (scripture.IsCompletelyHidden())
            {
                
                break;
            }

            Console.Write("Press Enter or write 'quit': ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}