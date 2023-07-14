using System;
namespace Foundation4{
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        //create activities
        Running run = new Running("13 Jul 20203",25,5);
        activities.Add(run);
        Cycling cycle = new Cycling("11 Dec 2023", 90,10.5);
        activities.Add(cycle);
        Swimming swim = new Swimming("15 Nov 2023", 20,10);
        activities.Add(swim);

        //iterate through activites and use getSummary()
        foreach (Activity act in activities){
            act.getSummary();
        }

    }
}
}