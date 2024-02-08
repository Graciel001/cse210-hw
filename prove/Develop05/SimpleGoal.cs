using System;

public class SimpleGoal : Goal
{
    public int Value { get; private set;}

    public SimpleGoal(string description, int value) : base(description, 0)
    {
        Value = value;
    }

    public override int GetValue()
    {
        return Value;
    }
}