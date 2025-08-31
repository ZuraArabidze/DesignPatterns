namespace DesignPatterns.Creational;

public interface IPrototype<T>
{
    T Clone();
}

public class Shape : IPrototype<Shape>
{
    public string Color { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public Shape Clone()
    {
        return new Shape
        {
            Color = this.Color,
            X = this.X,
            Y = this.Y
        };
    }

    public override string ToString()
    {
        return $"Shape: Color={Color}, Position=({X},{Y})";
    }
}

public class Circle : IPrototype<Circle>
{
    public string Color { get; set; }
    public double Radius { get; set; }

    public Circle Clone()
    {
        return new Circle
        {
            Color = this.Color,
            Radius = this.Radius
        };
    }

    public override string ToString()
    {
        return $"Circle: Color={Color}, Radius={Radius}";
    }
}
