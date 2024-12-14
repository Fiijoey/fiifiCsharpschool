public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isCompleted = false;
    }

    public override void RecordCompleted()
    {
        _isCompleted = true;
    }

    public override bool IsCompleted()
    {
        return _isCompleted;
    }

    public override string ReadFile()
    {
        return $"{GoalName},{GoalDescription},{GoalPoints},{_isCompleted}";
    }
}
