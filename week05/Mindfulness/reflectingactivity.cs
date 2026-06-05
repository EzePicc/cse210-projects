using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base(
        "Reflection Activity",
        "This activity encourages you to think about positive experiences in your life and recognize the skills and strengths that helped you succeed.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you overcame a challenge.",
            "Think of a time when you achieved an important goal.",
            "Think of a time when you learned something valuable.",
            "Think of a time when you made a positive difference in someone's life."
        };

        _questions = new List<string>
        {
            "What was going through your mind at the time?",
            "Who else was involved in this experience?",
            "What did you learn from the situation?",
            "What personal qualities helped you succeed?",
            "What was the biggest challenge you faced?",
            "How did this experience change your perspective?",
            "What are you most proud of?",
            "How might this experience help you in the future?",
            "What would you tell your past self about this experience?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        Console.WriteLine();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"  --- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have thought about this for a moment, you will be prompted with questions to deepen your reflection.");
        ShowSpinner(5);
    }

    private void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            
            Console.Write($"\n> {GetRandomQuestion()} ");
            int secondsLeft = (int)(endTime - DateTime.Now).TotalSeconds;
            int pauseTime = Math.Min(5, secondsLeft);
            ShowSpinner(pauseTime);
        }
    }
}