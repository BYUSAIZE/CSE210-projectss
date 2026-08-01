using System;

public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _completed = false;
    }

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return _points;
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override string GetStatus()
    {
        string mark = _completed ? "X" : " ";
        return $"[{mark}] {_name} ({_description})";
    }

    public override string SaveString()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_completed}";
    }
}