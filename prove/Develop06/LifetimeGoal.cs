public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordCompleted()
    {
        // Implementation for recording completion
    }

    public override bool IsCompleted()
    {
        // Eternal goals are never completed
        return false;
    }

    public override string ReadFile()
    {
        return $"{GoalName},{GoalDescription},{GoalPoints}";
    }
}
