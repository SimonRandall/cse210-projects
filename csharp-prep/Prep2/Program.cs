using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        Console.Write("What is the grade percentage? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade <90 && grade >= 80)
        {
            letter = "B";
        }

        else if (grade < 80 && grade >= 70)
        {
            letter = "C";
        }

        else if (grade < 70 && grade is >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"The letter grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats you passed!");
        }
        else
        {
            Console.WriteLine("You failed, keep trying");
        }


    }
}