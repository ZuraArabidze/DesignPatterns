namespace DesignPatterns.Structural;

public interface ICoffee
{
    string GetDescription();
    double GetCost();
}

public class BasicCoffee : ICoffee
{
    public string GetDescription() => "Basic Coffee";

    public double GetCost() => 2.0;
}

public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string GetDescription() => _coffee.GetDescription();

    public virtual double GetCost() => _coffee.GetCost();
}

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => _coffee.GetDescription() + ", Milk";

    public override double GetCost() => _coffee.GetCost() + 1.5;
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => _coffee.GetDescription() + ", Sugar";

    public override double GetCost() => _coffee.GetCost() + 1.2;
}