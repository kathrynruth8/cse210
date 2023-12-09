using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Green", 4);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Yellow", 4, 2);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Purple", 5);
        shapes.Add(shape3);

        Square shape4 = new Square("Red", 2);
        shapes.Add(shape4);

        Rectangle shape5 = new Rectangle("Blue", 3, 5);
        shapes.Add(shape5);

        Circle shape6 = new Circle("Black", 4);
        shapes.Add(shape6);

        Square shape7 = new Square("Pink", 9);
        shapes.Add(shape7);

        Rectangle shape8 = new Rectangle("Gray", 6, 8);
        shapes.Add(shape8);

        Circle shape9 = new Circle("Brown", 10);
        shapes.Add(shape9);

        Square shape10 = new Square("Dark Blue", 1);
        shapes.Add(shape10);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

        
    }
}