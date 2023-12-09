public class Square : Shape
{
// Attributes
    private double Side;
// Constructors
public Square(string color, double side) : base(color)
{
    Side = side;
}
// Methods
public override double GetArea()
{
    return Side * Side;
}

}