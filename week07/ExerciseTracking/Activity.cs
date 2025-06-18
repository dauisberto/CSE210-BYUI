public abstract class Activity
{
    private string _date;
    protected int _minutes;
    private string _description;

    public Activity(string date, int minutes, string description)
    {
        _date = date;
        _minutes = minutes;
        _description = description;

    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_description} ({_minutes}) min - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
    }

}