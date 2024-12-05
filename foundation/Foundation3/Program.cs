using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0), // 30 minutes run, 3 miles
            new Cycling(new DateTime(2022, 11, 3), 45, 12.0), // 45 minutes cycling, 12 mph speed
            new Swimming(new DateTime(2022, 11, 3), 40, 30) // 40 minutes swimming, 30 laps
        };

        // Iterate through each activity and display the summary
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
