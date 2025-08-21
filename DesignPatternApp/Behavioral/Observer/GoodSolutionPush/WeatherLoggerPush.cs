namespace ch.px.designpattern.Behavioral.Observer.GoodSolutionPush;

internal class WeatherLoggerPush : IObserver<WeatherData>
{
    public void OnNext(WeatherData observable)
    {
        Console.WriteLine($"[LoggerPush] LOG: {DateTime.Now}: Temp={observable.Temperature}°C, Humidity={observable.Humidity}%");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"[LoggerPush] Fehler: {error.Message}");
    }

    public void OnCompleted()
    {
        Console.WriteLine("[LoggerPush] Datenstrom beendet.");
    }
}
