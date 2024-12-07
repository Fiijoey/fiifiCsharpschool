using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }
    private static Dictionary<string, int> activityLog = new Dictionary<string, int>();

    public void Start()
    {
        Console.WriteLine($"Starting {Name} Activity");
        Console.WriteLine(Description);
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        ShowSpinner(3);
        LogActivity();
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    private void LogActivity()
    {
        if (activityLog.ContainsKey(Name))
        {
            activityLog[Name]++;
        }
        else
        {
            activityLog[Name] = 1;
        }
    }

    //Keeping a log of how many times activities were performed.
    public static void DisplayActivityLog()
    {
        Console.WriteLine("Activity Log:");
        foreach (var entry in activityLog)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
    }

    public abstract void PerformActivity();
}
