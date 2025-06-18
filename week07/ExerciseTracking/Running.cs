public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, string description, double distance) : base(date, minutes, description)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed;
        speed = (_distance / _minutes)*60;
        return speed;
    }

    public override double GetPace()
    {
        double pace;
        pace = _minutes / _distance;
        return pace;
    }

    
}