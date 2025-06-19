public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override string GetDetailsString()
    {
        return ($"[ ] - {_shortName} - {_description} - {_points} points");
    }

    public override string GetStringRepresentation()
    {
        return ($"EternalGoal:{_shortName},{_description},{_points},{IsComplete()}");
    }

    public override void RecordEvent()
    {

    }

    
}