namespace DesignPatterns.Behavioral;

public interface ICustomer
{
    string GetName();
    void PlaceOrder(string item);
}

public class RealCustomer : ICustomer
{
    private readonly string _name;

    public RealCustomer(string name)
    {
        _name = name;
    }

    public string GetName() => _name;

    public void PlaceOrder(string item)
    {
        Console.WriteLine($"{_name} placed an order for {item}.");
    }
}

public class NullCustomer : ICustomer
{
    public string GetName() => "No customer found";

    public void PlaceOrder(string item)
    {
        Console.WriteLine("No action taken. This is a Null Customer.");
    }
}

public class CustomerRepository
{
    private readonly List<string> _customers = new List<string>
    {
        "Zura", "Zura1", "Zura2"
    };

    public ICustomer GetCustomer(string name)
    {
        if (_customers.Contains(name))
            return new RealCustomer(name);

        return new NullCustomer();
    }
}
