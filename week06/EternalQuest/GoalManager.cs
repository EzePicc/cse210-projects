using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running= true;
        while (running)

        {
            Console.WriteLine($"You have {_score} points.\n");
            Console.WriteLine("Menu");
            Console.WriteLine("1 Create goal");
            Console.WriteLine("2 List goals");
            Console.WriteLine("3 Record event");
            Console.WriteLine("4 Save goals");
            Console.WriteLine("5 Load goals");
            Console.WriteLine("6 Stop");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoalDetails();
            else if (choice == "3") RecordEvent();
            else if (choice == "4") SaveGoals();
            else if (choice == "5") LoadGoals();
            else if (choice == "6") running = false;
        }

    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoals:");
        for (int i= 0; i< _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{_goals[i].GetDetailsString()}");
        }
    }
    
}