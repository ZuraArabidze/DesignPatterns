namespace DesignPatterns.Creational;

public sealed class Singleton
{
    private static Singleton _instance;
    private static readonly object _lock = new object();

    private Singleton()
    {
        Console.WriteLine("Singleton instance created");
    }

    public static Singleton GetInstance()
    {
        lock (_lock)
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Doing something with the singleton instance.");
    }
}
