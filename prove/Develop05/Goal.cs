using System;

public class Goal
{
    public string Description { get; private set; }
    public bool IsCompleted { get; private set; }
    public int Points { get; private set; }

    public Goal(string description, int points)
    {
        Description = description;
        IsCompleted = false;
        Points = points;
    }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
    }

    public override string ToString()
    {
        return $"{(IsCompleted ? "[X]" : "[ ]")} {Description}";
    }
}
