public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, string description, int laps) : base(date, minutes, description)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance;
        distance = _laps * 50 / 1000.0;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed;
        speed = (GetDistance() / _minutes) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace;
        pace = 60 / GetSpeed();
        return pace;
    }
}