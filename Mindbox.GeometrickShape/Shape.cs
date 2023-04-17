using Mindbox.GeometrickShape;
using System;

public abstract class Shape : IVisitable
{
    public abstract double Area();

    public void Accept(AreaVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    public double Radius => radius;
}

public class Triangle : Shape
{
    private double a;
    private double b;
    private double c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double Area()
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public double A => a;
    public double B => b;
    public double C => c;
}

public class AreaVisitor
{
    public double CircleArea { get; private set; }
    public double TriangleArea { get; private set; }

    public void Visit(Circle circle)
    {
        CircleArea = circle.Area();
    }

    public void Visit(Triangle triangle)
    {
        TriangleArea = triangle.Area();
    }

    public void Visit(Shape shape)
    {
        // Обработка других фигур, если нужно
    }
}