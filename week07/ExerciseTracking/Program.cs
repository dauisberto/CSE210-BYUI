using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("Jan 27th, 2022", 30, "Running", 4.8);
        Swimming swim = new Swimming("Jan 27th, 2025", 45, "Swimming", 4);
        Cycling cycle = new Cycling("Jan 27th, 2025", 62, "Cycling", 35);
        List<Activity> activities = new List<Activity>();

        activities.Add(run);
        activities.Add(swim);
        activities.Add(cycle);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }


        
        
    }
}