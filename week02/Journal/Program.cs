// Exceeded requirements:
// Implementing input validation using TryParse
// Handling missing or corrupted files safely
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("°* My Daily Journal *°");
            Console.WriteLine("1. Write About My Day");
            Console.WriteLine("2. View Entries");
            Console.WriteLine("3. Open Journal File");
            Console.WriteLine("4. Save Current Journal");
            Console.WriteLine("5. Close Program");

            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            bool isValid = int.TryParse(userInput, out choice);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
                continue;
            }

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string answer = Console.ReadLine();

                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();

                Entry newEntry = new Entry();

                newEntry._date = dateText;
                newEntry._promptText = prompt;
                newEntry._entryText = answer;

                theJournal.AddEntry(newEntry);
            }

            else if (choice == 2)
            {
                Console.WriteLine();
                theJournal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                // Here it prevent crash if file does not exist
                if (File.Exists(file))
                {
                    theJournal.LoadFromFile(file);
                    Console.WriteLine("Journal loaded.");
                }
                else
                {
                    Console.WriteLine("File not found. Please try again.");
                }
            }

            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();

                theJournal.SaveToFile(file);

                Console.WriteLine("Journal saved.");
            }

            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}