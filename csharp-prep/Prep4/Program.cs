using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumb = -1;
        while (userNumb != 0){
            Console.Write("Enter a number (0 to quit): ");

            string response = Console.ReadLine();
            userNumb = int.Parse(response);

            if (userNumb != 0){
                numbers.Add(userNumb);
            }
        }

        int sum = 0;
        foreach (int number in numbers){
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Part 2 average

        float average = ((float)sum) / numbers.Count();
        Console.WriteLine($"The average is: {average}");

        //parts 3 the max

        int max = numbers[0];
        foreach (int number in numbers){
            if(number > max){
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}