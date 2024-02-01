public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Clear your mind and focus on your breathing.");

        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation("Spinner Animation");
            Console.WriteLine("Breathe out...");
            PauseWithAnimation("Spinner Animation");
        }

        DisplayEndingMessage();
    }
}
