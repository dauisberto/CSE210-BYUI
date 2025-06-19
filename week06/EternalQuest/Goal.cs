public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    protected bool _isComplete;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public abstract void RecordEvent();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    public string GetGoalName()
    {
        return _shortName;
    }

    public string GetPoints()
    {
        return _points;
    }

}