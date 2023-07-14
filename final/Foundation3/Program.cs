using System;

namespace Foundation3{
class Program
{
    static void Main(string[] args)
    {
      // make addresses
      Address add1 = new Address("Lecture Hall 1, 100 street, Richmond TX");
      Address add2 = new Address("S 2nd W & 3rd W, Rexburg, ID 83440");
      Address add3 = new Address("55 2nd W, Rexburg, ID 83440");

      //create events
      string des1 = "Lecture on physics by Dr.Physics Man";
      string des2 = "Super cool and awesome outside event";
      string des3 = "This is a reception";

      Lecture event1 = new Lecture("Physics",des1,"9/05/23","5:00PM",add1,"Dr.Physics Man",500);
      Outside event2 = new Outside("Wilderness Activity",des2,"08/15/23","9:00AM",add2,"Sunny weather");
      Reception event3 = new Reception("Wedding", des3,"12/23/23","6:00PM",add3,"reception@gmail.com");

      // print standard details, short details, and full details
      List<Event> events = new List<Event>(){event1,event2,event3};
      foreach (Event input in events){
        Console.WriteLine("\nStandard details");
        Console.WriteLine(input.standardDetails());
        Console.WriteLine("\nShort details");
        input.shortDescription();
        Console.WriteLine("\nFull details");
        input.fullDetails();
      }

    }
}
}