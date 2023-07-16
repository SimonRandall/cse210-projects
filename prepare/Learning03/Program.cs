using System;
namespace learning03{


class Program
{
    static void Main(string[] args)
    {
        fraction type1 = new fraction();
        Console.WriteLine(type1.getFractionString());
        Console.WriteLine(type1.getDecimalValue());

        fraction type2 = new fraction(5);
        Console.WriteLine(type2.getFractionString());
        Console.WriteLine(type2.getDecimalValue());

        fraction type3 = new fraction(6,7);
        Console.WriteLine(type3.getFractionString());
        Console.WriteLine(type3.getDecimalValue());
        
        Console.WriteLine($"\nTesting getters and setters:\n {type1.getTop()} is top of type 1\n{type3.getBottom()} is bottom of type3");
    }
}
}