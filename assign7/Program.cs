using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class assign7
{
    public abstract double CalculateArea();
}

class Circle : assign7
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}


class Rectangle : assign7
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
    }
}

