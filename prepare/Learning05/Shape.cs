public abstract class Shape
{
// Attributes
private string Color;
// Constructors
public Shape(string color)
{
    Color = color;
}
public string GetColor()
    {
        return Color;
    }

public void SetColor(string color)
    {
        Color = color;
    }
// Methods
public abstract double GetArea();

}

