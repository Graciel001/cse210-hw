using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "Help the user pace their breathing");
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection", "Reflect on times in your life when you have shown strength and resilience.");
        ListingActivity listingActivity = new ListingActivity("Listing", "Reflect on the good things in your life by listing as many things as you can in a certain area.");

        breathingActivity.Run();
        reflectionActivity.Run();
        listingActivity.Run();
    }
}
