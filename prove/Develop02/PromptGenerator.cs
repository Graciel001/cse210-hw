using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Definition of the prompts list
    private List<string> _prompts;

    public PromptGenerator()
    {
        // Initialize the list
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public string GetRandomPrompt()
    {
        if (_prompts.Count > 0)
        {
            // Get random index
            int randomIndex = new Random().Next(0, _prompts.Count);

            // Get random prompt
            string randomPrompt = _prompts[randomIndex];

            //Display the prompt
            //Console.WriteLine($"Random Prompt: {randomPrompt}");

            //Remove the prompt of the list
            _prompts.RemoveAt(randomIndex);

            return randomPrompt;
        }
        else
        {
            Console.WriteLine("No prompts available.");
            return string.Empty;
        }
    }
}



