using System;

class Program
{
    static void Main(string[] args)
    {
        welcomeMessage();

        string userName = UserName();
        int userNumber = UserNumb();

        int squaredNumber = squareNumb(userNumber);

        Result(userName, squaredNumber);
    }
    static void welcomeMessage(){
        Console.WriteLine("Welcome!");
    }
    
    static string UserName(){
        Console.Write("enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int UserNumb(){
        Console.Write("enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int squareNumb(int number){
        int square = number * number;

        return square;
    }

    static void Result(string name, int square){
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}