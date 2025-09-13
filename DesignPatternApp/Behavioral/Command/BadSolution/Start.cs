namespace ch.px.designpattern.Behavioral.Command.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Command Pattern - Bad Solution");

        var light = new Light();
        var remoteControl = new RemoteControl(light);

        remoteControl.PressButton(true);
        remoteControl.PressButton(false);
    }
}