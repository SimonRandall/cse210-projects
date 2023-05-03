using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._jobCompany = "Apple";
        job1._startYear = "2019";
        job1._endYear = "2022";

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._jobCompany = "Microsoft";
        job2._startYear = "1883";
        job2._endYear = "1900";

        Resume myResume = new Resume();
        myResume._name = "Simon Randall";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.displayResume();


    }
}