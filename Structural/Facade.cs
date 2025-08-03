namespace DesignPatterns.Structural;

public class DvdPlayer
{
    public void On() => Console.WriteLine("DVD Player On");
    public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
    public void Off() => Console.WriteLine("DVD Player Off");
}

public class Projector
{
    public void On() => Console.WriteLine("Projector On");
    public void SetWideScreen() => Console.WriteLine("Projector in widescreen mode");
    public void Off() => Console.WriteLine("Projector Off");
}

public class SoundSystem
{
    public void On() => Console.WriteLine("Sound System On");
    public void SetVolume(int level) => Console.WriteLine($"Volume set to {level}");
    public void Off() => Console.WriteLine("Sound System Off");
}

public class Lights
{
    public void Dim(int level) => Console.WriteLine($"Lights dimmed to {level}%");
}


public class HomeTheaterFacade
{
    private readonly DvdPlayer _dvd;
    private readonly Projector _projector;
    private readonly SoundSystem _sound;
    private readonly Lights _lights;

    public HomeTheaterFacade(DvdPlayer dvd, Projector projector, SoundSystem sound, Lights lights)
    {
        _dvd = dvd;
        _projector = projector;
        _sound = sound;
        _lights = lights;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        _lights.Dim(10);
        _projector.On();
        _projector.SetWideScreen();
        _sound.On();
        _sound.SetVolume(15);
        _dvd.On();
        _dvd.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting down home theater...");
        _dvd.Off();
        _sound.Off();
        _projector.Off();
    }
}

