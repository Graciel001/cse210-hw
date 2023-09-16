using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentege? ");
        string answer = Console.ReadLine();
        int percentege = int.Parse(answer);

        string letter = "";

        if(percentege >= 90){
            letter = "A";

        }
        else if(percentege >= 80){
            letter = "B";
        }
        else if(percentege >= 70){
            letter = "C";
        }
        else if(percentege >= 60){
            letter = "D";
        }
        else{
            letter = "F";
        }

        Console.WriteLine($"Your Grade is {letter}");

        if(percentege >= 70){
            Console.WriteLine("Congratulations you passed!");
        }
        else{
            Console.WriteLine("Luck for the next time");
        }
    }
}