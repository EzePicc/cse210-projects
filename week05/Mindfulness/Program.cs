// Exceeding Requirement: The program tracks how many times each activity has been performed
// during the session and displays the log in the menu.

// No repeat questions: ReflectingActivity shuffles its question list and cycles
// through all questions before repeating any in a session.

using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> _log = new Dictionary<string, int>
    {
        { "Breathing", 0 },
        { "Reflection", 0 },
        { "Listing", 0 }
    };

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing act");
            Console.WriteLine("  2. Start reflecting act");
            Console.WriteLine("  3. Start listing act");
            Console.WriteLine("  4. Quit");


            Console.WriteLine("\n== Session Log ==");
            foreach (var entry in _log)
                Console.WriteLine($"  {entry.Key}: {entry.Value} times");
            Console.WriteLine("===================");

            Console.Write("\nChose one from the menu: ");
            choice = Console.ReadLine();
            
            if (choice == "1")

            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();

                _log["Breathing"]++;
            }

            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();

                _log["Reflection"]++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                _log["Listing"]++;

            }
        }

    }
}