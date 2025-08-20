namespace ch.px.designpattern.Structural.Bridge.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Bridge - Bad Solution");

        var lgRadio = new LGRemote();
        lgRadio.TurnOn();
        lgRadio.TurnOff();

        var lgRadioAndTVRemote = new LGRadioAndTVRemote();
        lgRadioAndTVRemote.ControlTV(); // Now controlling LG TV
        lgRadioAndTVRemote.TurnOn();    // Turning LG Device on
        lgRadioAndTVRemote.VolumeUp();  // Turning LG Device volume up
    }
}