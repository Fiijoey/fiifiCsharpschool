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
    }

    public void SaveGoalList(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.ReadFile());
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
                // Parse the line and create appropriate Goal objects
                // Add them to the _goals list
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
