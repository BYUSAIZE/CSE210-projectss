using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();
            Console.WriteLine($"Current Score: {_score} points");
            Console.WriteLine();

            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;

                case 2:
                    ListGoals();
                    break;

                case 3:
                    SaveGoals();
                    break;

                case 4:
                    LoadGoals();
                    break;

                case 5:
                    RecordEvent();
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.Clear();

        Console.WriteLine("Goal Types");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Choose Goal Type: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else
        {
            Console.Write("How many times must it be completed? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus Points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    private void ListGoals()
    {
        Console.Clear();

        Console.WriteLine("Your Goals");
        Console.WriteLine();

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }

        Console.WriteLine();
        Console.Write("Press Enter...");
        Console.ReadLine();
    }

    private void RecordEvent()
    {
        ListGoals();

        Console.Write("Select Goal Number: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            int earned = _goals[choice].RecordEvent();
            _score += earned;

            Console.WriteLine();
            Console.WriteLine($"Congratulations! You earned {earned} points.");
            Console.WriteLine($"Total Score: {_score}");

            Console.ReadLine();
        }
    }

    private void SaveGoals()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(file))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.SaveString());
            }
        }

        Console.WriteLine("Goals saved successfully.");
        Console.ReadLine();
    }

    private void LoadGoals()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            Console.ReadLine();
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(file);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "Simple")
            {
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));

                if (bool.Parse(parts[4]))
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
            else if (parts[0] == "Eternal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "Checklist")
            {
                ChecklistGoal goal = new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[5]),
                    int.Parse(parts[4]));

                int completed = int.Parse(parts[6]);

                while (goal.GetCount() < completed)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
        Console.ReadLine();
    }
}