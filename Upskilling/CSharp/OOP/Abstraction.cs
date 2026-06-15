using System;

abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return 3.14 * Radius * Radius;
    }
}

class Abstraction
{
    static void Main()
    {
        Shape shape = new Circle(5);

        Console.WriteLine("Area: " + shape.CalculateArea());
    }
}
