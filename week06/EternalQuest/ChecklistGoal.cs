public class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _isComplete = true;
        }
    }

    public override string GetDetailsString()
    {
        string checkbox;
        checkbox = "";
        if (_isComplete == true)
        {
            checkbox = "X";
        }
        return ($"[{checkbox}] - {_shortName} - {_description} - {_points} points -- Progress:{_amountCompleted}/{_target}");
    }

    public override string GetStringRepresentation()
    {
        return ($"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}");
    }

    public int GetBonus()
    {
        return _bonus;
    }



}