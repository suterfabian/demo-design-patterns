namespace ch.px.designpattern.Observer.GoodSolutionPush;

internal class WeatherDisplayPush : IObserver<WeatherData>
{
    public void OnNext(WeatherData value)
    {
        Console.WriteLine($"[DisplayPush] Temperatur: {value.Temperature}°C, Luftfeuchtigkeit: {value.Humidity}%");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"[DisplayPush] Fehler: {error.Message}");
    }

    public void OnCompleted()
    {
        Console.WriteLine("[DisplayPush] Keine weiteren Daten.");
    }
}