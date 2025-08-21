namespace ch.px.designpattern.Behavioral.Observer.GoodSolutionPush;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Observer - Good Solution Push");

        var pushStation = new WeatherStationPush();

        var pushDisplay = new WeatherDisplayPush();
        var pushAlert = new WeatherAlertPush();
        var pushLogger = new WeatherLoggerPush();

        using var display = pushStation.Subscribe(pushDisplay);
        using var alert = pushStation.Subscribe(pushAlert);
        using var logger = pushStation.Subscribe(pushLogger);

        pushStation.SetMeasurements(22.5f, 55f);
        pushStation.SetMeasurements(23f, 60f);
        pushStation.EndTransmission();

        pushStation.SetMeasurements(17f, 87f);
        pushStation.EndTransmission();
    }
}