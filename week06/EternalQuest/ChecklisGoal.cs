using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _completed;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _completed = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_completed < _target)
        {
            _completed++;

            if (_completed == _target)
            {
                Console.WriteLine("Congratulations! You completed the goal and earned the bonus!");
                return _points + _bonus;
            }

            return _points;
        }

        Console.WriteLine("This goal has already been completed.");
        return 0;
    }

    public override bool IsComplete()
    {
        return _completed >= _target;
    }

    public override string GetStatus()
    {
        string mark = IsComplete() ? "X" : " ";
        return $"[{mark}] {_name} ({_description}) -- Completed {_completed}/{_target}";
    }

    // Used by GoalManager when loading saved goals
    public int GetCount()
    {
        return _completed;
    }

    // Optional helper method
    public int GetTarget()
    {
        return _target;
    }

    public override string SaveString()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_bonus}|{_target}|{_completed}";
    }
}