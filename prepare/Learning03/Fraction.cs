public class Fraction {
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int inputWholeNumber)
    {
        _top = inputWholeNumber;
        _bottom = 1;
    }
    public Fraction(int inputTop, int inputBottom)
    {
        _top = inputTop;
        _bottom = inputBottom;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        return (double)_top  / (double)_bottom;
    }
}