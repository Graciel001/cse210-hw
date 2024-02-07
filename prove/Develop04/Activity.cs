using System;
using System.Threading;

public class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void SetDuration(int duration)
    {
        Duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {Name} Activity: {Description}");
        Console.WriteLine($"Setting duration to {Duration} seconds.");
        Console.Write("Get ready to begin...");
        Thread.Sleep(3000);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Great job! You've completed the {Name} Activity.");
        Console.WriteLine($"Total time: {Duration} seconds.");
        Thread.Sleep(3000);
    }

    public void PauseWithAnimation(string animation)
    {
        Console.WriteLine(animation);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
}
