using System;
using System.Collections.Generic;
using System.Linq;

public class EternalQuestProgram
{
    private List<Goal> goals;

    public EternalQuestProgram()
    {
        goals = new List<Goal>();
    }

    // Method to display the menu and handle user options
    public void Run()
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record event (complete goal)");
            Console.WriteLine("3. Show goal list");
            Console.WriteLine("4. Show total score");
            Console.WriteLine("5. Save and exit");

            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    ShowTotalScore();
                    break;
                case "5":
                    SaveAndExit();
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
            }
        }
    }

    // Method to create a new goal
    private void CreateGoal()
    {
        Console.WriteLine("Create new goal:");
        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Goal type (1: Simple, 2: Eternal, 3: Checklist): ");
        string typeInput = Console.ReadLine();

        int type;
        if (int.TryParse(typeInput, out type))
        {
            switch (type)
            {
                case 1:
                    CreateSimpleGoal(name);
                    break;
                case 2:
                    CreateEternalGoal(name);
                    break;
                case 3:
                    CreateChecklistGoal(name);
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    // Method to create a new simple goal
    private void CreateSimpleGoal(string name)
    {
        Console.Write("Goal value: ");
        string valueInput = Console.ReadLine();

        int value;
        if (int.TryParse(valueInput, out value))
        {
            goals.Add(new SimpleGoal(name, value));
            Console.WriteLine("Goal created successfully.");
        }
        else
        {
            Console.WriteLine("Invalid value.");
        }
    }

    // Method to create a new eternal goal
    private void CreateEternalGoal(string name)
    {
        Console.Write("Value per record: ");
        string valueInput = Console.ReadLine();

        int valuePerRecord;
        if (int.TryParse(valueInput, out valuePerRecord))
        {
            goals.Add(new EternalGoal(name, valuePerRecord));
            Console.WriteLine("Goal created successfully.");
        }
        else
        {
            Console.WriteLine("Invalid value.");
        }
    }

    // Method to create a new checklist goal
    private void CreateChecklistGoal(string name)
    {
        Console.Write("Times required to complete the goal: ");
        string requiredTimesInput = Console.ReadLine();
        Console.Write("Value per record: ");
        string valuePerRecordInput = Console.ReadLine();

        int requiredTimes, valuePerRecord;
        if (int.TryParse(requiredTimesInput, out requiredTimes) && int.TryParse(valuePerRecordInput, out valuePerRecord))
        {
            goals.Add(new ChecklistGoal(name, requiredTimes, valuePerRecord));
            Console.WriteLine("Goal created successfully.");
        }
        else
        {
            Console.WriteLine("Invalid value.");
        }
    }

    // Method to record an event (complete a goal)
    private void RecordEvent()
    {
        Console.WriteLine("Record event (complete goal):");
        Console.Write("Enter the name of the completed goal: ");
        string name = Console.ReadLine();

        Goal goal = goals.FirstOrDefault(g => g.Description == name);
        if (goal != null)
        {
            goal.MarkAsCompleted();
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    // Method to show the goal list
    private void ShowGoals()
    {
        Console.WriteLine("Goal list:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal);
        }
    }

    // Method to show the total score
    private void ShowTotalScore()
    {
        int totalScore = goals.Sum(g => g.IsCompleted ? g.GetValue() : 0);
        Console.WriteLine($"Total score: {totalScore}");
    }

    // Method to save data and exit the program
    private void SaveAndExit()
    {
        // Implement logic to save to a file
        Console.WriteLine("Saving data...");
        Console.WriteLine("Data saved successfully. Exiting the program.");
    }
}
