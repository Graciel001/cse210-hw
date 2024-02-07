using System;

public class ReflectionActivity : Activity
{
    public ReflectionActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");

        for (int i = 0; i < Duration; i++)
        {
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"Prompt: {randomPrompt}");
            PauseWithAnimation("Spinner Animation");

            AskReflectionQuestions();
        }

        DisplayEndingMessage();
    }

    private void AskReflectionQuestions()
    {
        string[] reflectionQuestions = new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        foreach (string question in reflectionQuestions)
        {
            Console.WriteLine(question);
            PauseWithAnimation("Spinner Animation");
        }
    }
}
