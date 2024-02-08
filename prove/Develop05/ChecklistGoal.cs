using System;

public class ChecklistGoal : Goal
{
    public int RequiredTimes { get; private set; }
    public int TimesCompleted { get; private set; }
    public int ValuePerRecord { get; private set; }

    public ChecklistGoal(string description, int requiredTimes, int valuePerRecord) : base(description, 0)
    {
        RequiredTimes = requiredTimes;
        ValuePerRecord = valuePerRecord;
        TimesCompleted = 0;
    }

    public override int GetValue()
    {
        return ValuePerRecord * TimesCompleted;
    }

    public void RecordEvent()
    {
        TimesCompleted++;
    }

    public bool IsGoalComplete()
    {
        return TimesCompleted >= RequiredTimes;
    }

    public int GetBonusPoints()
    {
        return IsGoalComplete() ? 500 : 0;
    }

    public override string ToString()
    {
        string status = IsGoalComplete() ? "[X]" : "[ ]";
        return $"{status} {Description} - Completed {TimesCompleted}/{RequiredTimes} times";
    }
}
