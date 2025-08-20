namespace ch.px.designpattern.Structural.Bridge.BadSolution;
internal class LGRadioAndTVRemote : RadioAndTVRemote
{
    public override void ControlRadio()
    {
        Console.WriteLine("Now controlling LG Radio");
    }

    public override void ControlTV()
    {
        Console.WriteLine("Now controlling LG TV");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Turning LG Device off");
    }

    public override void TurnOn()
    {
        Console.WriteLine("Turning LG Device on");
    }

    public override void VolumeDown()
    {
        Console.WriteLine("Turning LG Device volume down");
    }

    public override void VolumeUp()
    {
        Console.WriteLine("Turning LG Device volume up");
    }
}
