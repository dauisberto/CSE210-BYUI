public class Fractions

{
    private int _top;
    private int _bottom;

    public Fractions()
    {

        _top = 1;
        _bottom = 1;
    }

    public Fractions(int wholeNumber)
    {

        _top = wholeNumber;
        _bottom = 1;

    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }

    public string GetFractionString()
    {
        string fraction_text = "";
        fraction_text = $"{_top}/{_bottom}";
        return fraction_text;
    }

    public double GetDecimalValue()
    {
        double fraction_result;
        fraction_result = (double)_top / (double)_bottom;
        return fraction_result;
    }
}
