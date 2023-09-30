public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;

    }

    public Fraction(int topNumber , int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionToString()
    {
        return $"{_top}/{_bottom}";
        
    }

    public double GetDecimalResult()
    {
        return (double)_top / _bottom;
    }

}