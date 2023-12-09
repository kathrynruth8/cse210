public class Circle : Shape
{
    // Attributes
    private double Radius;
    // Constructors
    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }
    // Methods
    public override double GetArea()
    {
        return Radius * Radius * Math.PI;
    }
}