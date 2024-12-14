public class ChecklistGoal : Goal
{
    private int _targetToComplete;
    private int _targetCompleted;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _targetToComplete = target;
        _bonusPoints = bonus;
        _targetCompleted = 0;
    }

    public override void RecordCompleted()
    {
        _targetCompleted++;
    }

    public override bool IsCompleted()
    {
        return _targetCompleted >= _targetToComplete;
    }

    public override string ReadFile()
    {
        return $"{GoalName},{GoalDescription},{GoalPoints},{_targetToComplete},{_targetCompleted},{_bonusPoints}";
    }

    public void AddStepCount()
    {
        _targetCompleted++;
    }

    // Public properties to access private fields
    public int TargetToComplete => _targetToComplete;
    public int TargetCompleted => _targetCompleted;
    public int BonusPoints => _bonusPoints;
}
