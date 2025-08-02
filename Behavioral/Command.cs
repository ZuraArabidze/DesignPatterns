
namespace DesignPatterns.Behavioral;

public interface ICommand
{
    void Execute();
    void Undo();
}

public class Light
{
    public void TurnOn() => Console.WriteLine("The light is ON");
    public void TurnOff() => Console.WriteLine("The light is OFF");
}

public class TurnOnCommand : ICommand
{
    private readonly Light _light;

    public TurnOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute() => _light.TurnOn();
    public void Undo() => _light.TurnOff();
}

public class TurnOffCommand : ICommand
{
    private readonly Light _light;

    public TurnOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute() => _light.TurnOff();
    public void Undo() => _light.TurnOn();
}

public class RemoteControl
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }

    public void PressUndo()
    {
        _command.Undo();
    }
}
