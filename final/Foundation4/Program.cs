using System;
using Foundation4;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running r = new Running(new DateTime(2023, 1, 17), 60, 4);
        Cycling c = new Cycling(new DateTime(2022, 1, 13), 45, 19);
        Swimming s = new Swimming(new DateTime(2021, 1, 25), 20, 7);

        // Add all the activities in a the list
        activities.Add(r);
        activities.Add(c);
        activities.Add(s);

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"Activity: {activity.GetActivitySummary()}");
        }
    }
}