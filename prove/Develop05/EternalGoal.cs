using System;

public class EternalGoal : Goal
{
    public int ValuePerRecord { get; private set; }
    public int RecordsCompleted { get; private set; }

    public EternalGoal(string description, int valuePerRecord) : base(description, 0)
    {
        ValuePerRecord = valuePerRecord;
        RecordsCompleted = 0;
    }

    public override int GetValue()
    {
        return ValuePerRecord * RecordsCompleted;
    }

    public void RecordEvent()
    {
        RecordsCompleted++;
    }
}
