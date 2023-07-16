using System;

namespace Learning04{

class Program
{
    static void Main(string[] args)
    {
        Assignment first = new Assignment("Simon Randall", "Engineering");
        Console.WriteLine(first.getSummary());

        MathAssignment second = new MathAssignment("Simon Randall", "Calculus", "Section 5", "Problems 20-32");
        Console.WriteLine($"\n{second.getSummary()}");
        Console.WriteLine(second.getHomeworkList());

        WritingAssignment third = new WritingAssignment("Simon Randall", "English", "An Essay About Stuff");
        Console.WriteLine($"\n{third.getSummary()}");
        Console.WriteLine(third.getWritingInfo());
    }
}
}