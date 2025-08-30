namespace DesignPatterns.Behavioral;

public interface IPlayerState
{
    void Play(MusicPlayer player);
    void Pause(MusicPlayer player);
    void Stop(MusicPlayer player);
}

public class MusicPlayer
{
    private IPlayerState _state;

    public MusicPlayer()
    {
        _state = new StoppedState();
    }

    public void SetState(IPlayerState state)
    {
        _state = state;
    }

    public void Play() => _state.Play(this);
    public void Pause() => _state.Pause(this);
    public void Stop() => _state.Stop(this);
}

public class StoppedState : IPlayerState
{
    public void Play(MusicPlayer player)
    {
        Console.WriteLine("Music starts playing.");
        player.SetState(new PlayingState());
    }

    public void Pause(MusicPlayer player)
    {
        Console.WriteLine("Cannot pause. Music is stopped.");
    }

    public void Stop(MusicPlayer player)
    {
        Console.WriteLine("Music is already stopped.");
    }
}

public class PlayingState : IPlayerState
{
    public void Play(MusicPlayer player)
    {
        Console.WriteLine("Music is already playing.");
    }

    public void Pause(MusicPlayer player)
    {
        Console.WriteLine("Music paused.");
        player.SetState(new PausedState());
    }

    public void Stop(MusicPlayer player)
    {
        Console.WriteLine("Music stopped.");
        player.SetState(new StoppedState());
    }
}

public class PausedState : IPlayerState
{
    public void Play(MusicPlayer player)
    {
        Console.WriteLine("Resuming music.");
        player.SetState(new PlayingState());
    }

    public void Pause(MusicPlayer player)
    {
        Console.WriteLine("Music is already paused.");
    }

    public void Stop(MusicPlayer player)
    {
        Console.WriteLine("Music stopped from paused state.");
        player.SetState(new StoppedState());
    }
}



