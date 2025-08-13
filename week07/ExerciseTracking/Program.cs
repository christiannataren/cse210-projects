using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(DateTime.Now, 30, 4.8));
        activities.Add(new Cycling(DateTime.Now, 30, 6.25));
        activities.Add(new Swimming(DateTime.Now, 1, 1));
        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}