namespace ch.px.designpattern.Bridge.GoodSolution;
internal class SonyRadio : IDevice
{
    public void SetChannel(int channel)
    {
        Console.WriteLine($"Setting Sony radio to channel {channel}");
    }

    public void TurnOff()
    {
        Console.WriteLine("Turning Sony Radio off");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning Sony Radio on");
    }
}
