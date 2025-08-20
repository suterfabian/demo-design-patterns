namespace ch.px.designpattern.Structural.Bridge.GoodSolution;
internal class AdvancedRemote : RemoteControl
{
    public AdvancedRemote(IDevice device) : base(device)
    {
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine($"Set channel {channel}");
    }
}
