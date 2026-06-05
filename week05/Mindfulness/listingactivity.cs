using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    
    private List<string> _prompts;

    public ListingActivity() : base(
        "Listing Activity",
        "This activity helps you focus on positive aspects of your by helping yoy create lists based on different reflective topics.")
    
    {
        _prompts = new List<string>
        {
           "What are some things that made you smile recently?",
            "What skills or talents are you grateful to have?",
            "Who has had a positive influence on your life?",
            "What are some goals you have accomplished this year?",
            "What are some experiences that have taught you valuable lessons?"

        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine($"List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");

        ShowCountDown(5);
        Console.WriteLine();

        _count = GetListFromUser();

        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private int GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (input != null && input != "")
            {
                items.Add(input);
            }
        }

        return items.Count;

    }
}