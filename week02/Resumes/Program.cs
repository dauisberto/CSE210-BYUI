using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._company = "Mondelez";
        job1._jobTitle="Planner";
        job1._startYear=2017;
        job1._endYear=2021;

        Job job2 = new Job();
        job2._company="Google";
        job2._jobTitle="Coder";
        job2._startYear=2026;
        job2._endYear=2300;

        Resume cesar = new Resume();
        cesar._username="Cesar";
        cesar._works.Add(job1);
        cesar._works.Add(job2);

        cesar.DisplayResumeInfo();

        

    }
}