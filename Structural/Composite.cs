namespace DesignPatterns.Structural.Composite;

abstract class Graphic
{
    public abstract void Draw();
}

class Circle : Graphic
{
    public override void Draw() => Console.WriteLine("Drawing a Circle");
}

class Square : Graphic
{
    public override void Draw() => Console.WriteLine("Drawing a Square");
}

class CompoundGraphic : Graphic
{
    private List<Graphic> _children = new List<Graphic>();

    public void Add(Graphic graphic) => _children.Add(graphic);
    public void Remove(Graphic graphic) => _children.Remove(graphic);

    public override void Draw()
    {
        Console.WriteLine("Drawing a CompoundGraphic:");
        foreach (var child in _children)
        {
            child.Draw();
        }
    }
}
