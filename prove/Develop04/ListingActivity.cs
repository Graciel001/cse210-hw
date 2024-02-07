using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    public ListingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        for (int i = 0; i < Duration; i++)
        {
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"Prompt: {randomPrompt}");
            PauseWithAnimation("Spinner Animation");

            Console.WriteLine("Think and list as many items as you can...");
            List<string> items = GetListFromUser();
            Console.WriteLine($"Number of items listed: {items.Count}");
        }

        DisplayEndingMessage();
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        bool continueListing = true;
        while (continueListing)
        {
            Console.WriteLine("Enter an item (or type 'done' to finish listing)");
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
            {
                continueListing = false;
            }
            else
            {
                items.Add(input);
            }
        }

        return items;
    }
}
