Shape shape = new Rectangle() { Width = 10, Height = 20 };
Console.WriteLine(shape.Area());
Console.WriteLine(shape.Perimetr());
Console.WriteLine(shape.GetHashCode());

shape = new Circle() { Radius = 30 };
Console.WriteLine(shape.Area());
Console.WriteLine(shape.Perimetr());
Console.WriteLine(shape.GetHashCode());

Console.WriteLine(new Rectangle());

abstract class Shape
{
    public abstract double Area();
    public abstract double Perimetr();
}

class Rectangle : Shape
{
    public double Width { set; get; }
    public double Height { set; get; }
    public override double Area()
    {
        return Width * Height;
    }

    public override double Perimetr()
    {
        return (Width + Height) * 2;
    }

    public override string ToString()
    {
        return $"Rectangle width {Width}, height {Height}";
    }

    public override bool Equals(object? obj)
    {
        if(obj is not null && obj is Rectangle rectangle)
            return Width == rectangle.Width && Height == rectangle.Height;
        return false;
    }
}

class Circle : Shape
{
    public double Radius { set; get; }
    public override double Area()
    {
        return Radius * Radius * Math.PI;
    }

    public override double Perimetr()
    {
        return 2 * Radius * Math.PI;
    }
}