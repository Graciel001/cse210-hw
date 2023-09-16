using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumb = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumb){
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (magicNumb > guess){
                Console.WriteLine("High!");
            }
            else if (magicNumb < guess){
                Console.WriteLine("Lower!");
            }
            else {
                Console.WriteLine("Your guess!");
            }
        }
    }
}