using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Activity runningActivity = new Running(DateTime.Parse("2023-12-20"), 30, 3.0);
        Activity cyclingActivity = new Cycling(DateTime.Parse("2023-12-25"), 45, 10.0);
        Activity swimmingActivity = new Swimming(DateTime.Parse("2023-12-30"), 20, 15);

        List<Activity> activities = new List<Activity>
        {
            runningActivity,
            cyclingActivity,
            swimmingActivity
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}