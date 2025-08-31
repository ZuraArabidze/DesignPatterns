namespace DesignPatterns.Creational;

public class Car
{
    public string Engine { get; set; }
    public int Wheels { get; set; }
    public bool Sunroof { get; set; }

    public override string ToString()
    {
        return $"Car [Engine: {Engine}, Wheels: {Wheels}, Sunroof: {Sunroof}]";
    }
}

public interface ICarBuilder
{
    void Reset();
    void BuildEngine();
    void BuildWheels();
    void BuildSunroof();
    Car GetResult();
}

public class SportsCarBuilder : ICarBuilder
{
    private Car _car;

    public SportsCarBuilder() => Reset();

    public void Reset() => _car = new Car();

    public void BuildEngine() => _car.Engine = "V8 Turbo";
    public void BuildWheels() => _car.Wheels = 4;
    public void BuildSunroof() => _car.Sunroof = true;

    public Car GetResult() => _car;
}

public class SUVCarBuilder : ICarBuilder
{
    private Car _car;

    public SUVCarBuilder() => Reset();

    public void Reset() => _car = new Car();

    public void BuildEngine() => _car.Engine = "V6 Diesel";
    public void BuildWheels() => _car.Wheels = 4;
    public void BuildSunroof() => _car.Sunroof = false;

    public Car GetResult() => _car;
}

public class CarDirector
{
    public void Construct(ICarBuilder builder)
    {
        builder.Reset();
        builder.BuildEngine();
        builder.BuildWheels();
        builder.BuildSunroof();
    }
}


