namespace ch.px.designpattern.Bridge.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Bridge - Good Solution");

        var lgRemoteControl = new RemoteControl(new LGRadio());
        lgRemoteControl.TurnOn();
        lgRemoteControl.TurnOff();

        var advancedSonyControl = new AdvancedRemote(new SonyRadio());
        advancedSonyControl.TurnOn();
        advancedSonyControl.TurnOff();
        advancedSonyControl.SetChannel(11);
    }
}