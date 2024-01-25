using System;

public class ScriptureProgram
{
    private readonly ScriptureReference Reference;
    private readonly ScriptureText Text;

    public ScriptureProgram(ScriptureReference reference, ScriptureText text)
    {
        Reference = reference;
        Text = text;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine($"{Reference}\n{Text}");

        while (true)
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            Text.HideRandomWords();
            Console.Clear();
            Console.WriteLine($"{Reference}\n{Text}");
        }
    }
}