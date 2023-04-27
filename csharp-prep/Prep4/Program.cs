using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int loopBreaker = 1;
        int num = 0;
        int total = 0;
        int max = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (loopBreaker != 0)
        {
            Console.Write("Enter a number:");
            string Input = Console.ReadLine();
            num = int.Parse(Input);
            if (num != 0)
            {
                numbers.Add(num);
                if (num > max)
                {
                    max = num;
                }

            }
            else
            {
                loopBreaker = 0;
            }
        }

        foreach (int number in numbers)
        {
            total = total + number;
        }
        int amount = numbers.Count;
        double avg = (double)total / (double)amount;
        Console.WriteLine(amount);
        Console.WriteLine($"The Sum is : {total}");
        Console.WriteLine(avg);
        Console.WriteLine($"The max is {max}");
    }
}