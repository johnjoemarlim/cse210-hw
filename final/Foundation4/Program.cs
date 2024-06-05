using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        Running r1 = new Running(90, "05 June 2024", 3);
        activities.Add(r1);

        Cycling c1 = new Cycling(60, "06 June 2024", 15.00);
        activities.Add(c1);

        Swimming s1 = new Swimming(20, "07 June 2024", 5);
        activities.Add(s1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}