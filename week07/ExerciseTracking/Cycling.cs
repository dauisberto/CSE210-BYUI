public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, string description, double speed) : base(date, minutes, description)
    {
        _speed = speed;

    }

    public override double GetDistance()
    {
        double distance;
        distance = _minutes / GetPace();
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace;
        pace = 60 / _speed;
        return pace;
    } 

}