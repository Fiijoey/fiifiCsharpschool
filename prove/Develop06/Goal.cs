using System;

public abstract class Goal
{
    public string GoalName { get; set; }
    public string GoalDescription { get; set; }
    public int GoalPoints { get; set; }

    public Goal(string name, string description, int points)
    {
        GoalName = name;
        GoalDescription = description;
        GoalPoints = points;
    }

    public abstract void RecordCompleted();
    public abstract bool IsCompleted();
    public abstract string ReadFile();
    public string GetDetails()
    {
        return $"{GoalName}: {GoalDescription} - {GoalPoints} points";
    }
}
