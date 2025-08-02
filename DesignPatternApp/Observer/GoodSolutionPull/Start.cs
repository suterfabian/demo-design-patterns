namespace ch.px.designpattern.Observer.GoodSolutionPull;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Observer - Good Solution Pull");

        var pullStation = new WeatherStationPull();
        var pullDisplay = new WeatherDisplayPull();

        using var pullSub = pullStation.Subscribe(pullDisplay);

        pullStation.SetMeasurements(19f, 70f);
        pullStation.SetMeasurements(20f, 65f);

        pullStation.EndTransmission();
    }
}