using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("blue", 2);
        Rectangle s2 = new Rectangle("green", 2, 3);
        Circle s3 = new Circle("red", 2);

        shapes.Add(s1);
        shapes.Add(s2);
        shapes.Add(s3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"{color} {area}");
        }
    }
}