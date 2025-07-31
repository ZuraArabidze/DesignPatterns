
namespace DesignPatterns.Behavioral;

public interface IObserver
{
    void Update(string news);
}

public interface ISubject
{
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
    void Notify(string news);
}

public class NewsAgency : ISubject
{
    private readonly List<IObserver> _observers = new();

    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string news)
    {
        foreach (var observer in _observers)
        {
            observer.Update(news);
        }
    }

    public void PublishNews (string news)
    {
        Console.WriteLine($"[NewsAgency] Publishing news: {news}");
        Notify(news);
    }
}

public class NewsSubscriber : IObserver
{
    public string Name { get; }

    public NewsSubscriber(string name)
    {
        Name = name;
    }

    public void Update(string news)
    {
        Console.WriteLine($"[{Name}] received news: {news}");
    }
}


