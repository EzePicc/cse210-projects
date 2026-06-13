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
    public void CreateGoal()
    {
        Console.WriteLine("\nWhat type of goal?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select: ");
        string type = Console.ReadLine();
        Console.Write("Name:");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points) );
        }
        else if (type== "3")
        {
            Console.Write("Target: ");
            int target=int.Parse(Console.ReadLine());
            Console.Write("Extra points: ");
            int bonus= int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }
    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("\nWhich goal?: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal goal = _goals[index];
        goal.RecordEvent();
        Console.WriteLine($"You earned {goal.GetPoints()} points!");
        _score += goal.GetPoints();
    }
     public void SaveGoals()
    {
        Console.Write("\nFilename: ");
        string filename = Console.ReadLine();
        using (StreamWriter file= new StreamWriter(filename))
        {
            file.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal);
            }
        }

        Console.WriteLine("Saved!");
    }
    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string filename =Console.ReadLine();
        string[] lines =File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i= 1; i<lines.Length; i++)
        {
            string[] parts = lines[i].Split(";");
            string type = parts[0];
            string[] details = parts[1].Split("-");

            if (type == "SimpleGoal")
            {
                SimpleGoal g = new SimpleGoal(details[0], details[1], int.Parse(details[3]));
                if (details[3] == "True") g.RecordEvent();
                _goals.Add(g);
            }

            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[3])));
            }

            else if (type == "ChecklistGoal")
            {

                ChecklistGoal g= new ChecklistGoal(details[0], details[1], int.Parse(details[3]), int.Parse(details[4]), int.Parse(details[3]));
                int completed = int.Parse(details[4]);
                for (int j = 0; j< completed; j++) g.RecordEvent();
                _goals.Add(g);
            }
        }
        Console.WriteLine("Loaded!");

    }
}