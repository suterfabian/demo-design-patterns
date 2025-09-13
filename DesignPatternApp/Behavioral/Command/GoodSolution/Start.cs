namespace ch.px.designpattern.Behavioral.Command.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Command Pattern - Good Solution");

        var light = new Light();

        var remoteControl = new RemoteControl(new TurnOnCommand(light));
        remoteControl.PressButton();

        remoteControl.SetCommand(new DimCommand(light));
        remoteControl.PressButton();
    }
}