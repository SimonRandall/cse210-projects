using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name?");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?");
        string input = Console.ReadLine();
        int num = int.Parse(input);
        return num;
        
    }

    static int SquareNumber(int num)
    {
        int sum;
        sum = num * num;
        return sum;
    }

    static void DisplayResults(int squaredNum, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNum}");
    }   

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int squared = SquareNumber(num);
        DisplayResults(squared,name);
    }
}