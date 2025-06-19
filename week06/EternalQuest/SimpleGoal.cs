public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetDetailsString()
    {
        string checkbox;
        checkbox = "";
        if (_isComplete == true)
        {
            checkbox = "X";
        }

        return ($"[{checkbox}] - {_shortName} - {_description} - {_points} points");
    }

    public override string GetStringRepresentation()
    {
        return ($"SimpleGoal:{_shortName},{_description},{_points}");
    }
}