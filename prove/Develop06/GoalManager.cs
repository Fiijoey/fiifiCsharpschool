using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine($"Goal '{goal.GoalName}' has been added.");
    }

    public void SaveGoalList(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                string goalType = goal.GetType().Name;
                writer.WriteLine($"{goalType},{goal.ReadFile()}");
                Console.WriteLine("File has been save successfully.");
            }
        }
    }

    public void LoadGoalList(string filename)
    {
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(',');
                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                switch (goalType)
                {
                    case "SimpleGoal":
                        bool isCompleted = bool.Parse(parts[4]);
                        var simpleGoal = new SimpleGoal(name, description, points);
                        if (isCompleted) simpleGoal.RecordCompleted();
                        _goals.Add(simpleGoal); break;
                    case "EternalGoal":
                        var eternalGoal = new EternalGoal(name, description, points);
                        _goals.Add(eternalGoal);
                        break;
                    case "ChecklistGoal":
                        int targetToComplete = int.Parse(parts[4]);
                        int targetCompleted = int.Parse(parts[5]);
                        int bonusPoints = int.Parse(parts[6]);
                        var checklistGoal = new ChecklistGoal(name, description, points, targetToComplete, bonusPoints);
                        for (int i = 0; i < targetCompleted; i++) checklistGoal.RecordCompleted();
                        _goals.Add(checklistGoal);
                        break;

                }
            }
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_totalScore}");
    }

    public void DisplayDetails()
    {
        foreach (var goal in _goals)
        {
            string status = goal.IsCompleted() ? "[X]" : "[ ]";
            if (goal is ChecklistGoal checklistGoal)
            {
                status += $" Completed {checklistGoal.TargetCompleted}/{checklistGoal.TargetToComplete} times";
            }
            Console.WriteLine($"{status} {goal.GetDetails()}");
        }
    }


    public void MarkGoalCompleted(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.GoalName == goalName)
            {
                goal.RecordCompleted();
                _totalScore += goal.GoalPoints;
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted())
                {
                    _totalScore += checklistGoal.BonusPoints;
                }
                break;
            }
        }
    }
}
