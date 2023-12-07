using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create sample activities
        activities.Add(new Running(new DateTime(2023, 12, 5), 30, 3.0));
        activities.Add(new Running(new DateTime(2023, 12, 6), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2023, 12, 7), 45, 15.0));
        activities.Add(new Swimming(new DateTime(2023, 12, 8), 10, 40));

        // Display summaries for all activities
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}