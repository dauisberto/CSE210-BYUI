public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public string SetColor(string color)
    {
        _color = color;
        return _color;
    }

    public abstract double GetArea();
    
}