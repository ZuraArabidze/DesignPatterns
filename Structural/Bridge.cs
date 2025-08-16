
namespace DesignPatterns.Structural;

abstract class Shape
{
    protected IRenderer renderer;
    protected Shape(IRenderer renderer) => this.renderer = renderer;
    public abstract void Draw();
}

class Circle : Shape
{
    private float radius;
    public Circle(IRenderer renderer, float radius) : base(renderer)
        => this.radius = radius;

    public override void Draw() => renderer.RenderCircle(radius);
}

class Square : Shape
{
    private float side;
    public Square(IRenderer renderer, float side) : base(renderer)
        => this.side = side;

    public override void Draw() => renderer.RenderSquare(side);
}
interface IRenderer
{
    void RenderCircle(float radius);
    void RenderSquare(float side);
}

class RasterRenderer : IRenderer
{
    public void RenderCircle(float radius)
        => Console.WriteLine($"[Raster] Drawing pixels for a circle with radius {radius}");

    public void RenderSquare(float side)
        => Console.WriteLine($"[Raster] Drawing pixels for a square with side {side}");
}

class VectorRenderer : IRenderer
{
    public void RenderCircle(float radius)
        => Console.WriteLine($"[Vector] Drawing lines for a circle with radius {radius}");

    public void RenderSquare(float side)
        => Console.WriteLine($"[Vector] Drawing lines for a square with side {side}");
}
