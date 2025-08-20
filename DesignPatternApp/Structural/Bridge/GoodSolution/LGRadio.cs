namespace ch.px.designpattern.Structural.Bridge.GoodSolution;
internal class LGRadio : IDevice
{
    public void SetChannel(int channel)
    {
        Console.WriteLine($"Setting LG radio to channel {channel}");
    }

    public void TurnOff()
    {
        Console.WriteLine("Turning LG Radio off");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning LG Radio on");
    }
}
