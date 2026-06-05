using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;

    private int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int Duration => _duration;

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How many seconds would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready!");
        ShowSpinner(3);
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}.");
        ShowSpinner(3);
        
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinnerFrames = { "|", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerFrames[i % spinnerFrames.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write($"\b \b");
            int digits = i.ToString().Length;
            for (int d = 0; d < digits; d++)
                Console.Write("\b \b");
        }
    }
}