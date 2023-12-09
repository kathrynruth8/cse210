public class Rectangle : Shape
{
    // Attributes
    private double Length; 
    private double Width;
    // Constructors
    public Rectangle(string color, double length, double width) : base(color)
    {
        Length = length;
        Width = width;
    }
    // Methods
    public override double GetArea()
    {
        return Width * Length;
    }
}
