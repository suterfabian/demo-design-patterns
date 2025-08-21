namespace ch.px.designpattern.Behavioral.Observer.GoodSolutionPull;

internal class WeatherDisplayPull : IObserver<IPullObservable>
{
    public void OnNext(IPullObservable observable)
    {
        Console.WriteLine($"[Pull] Temperatur: {observable.Temperature}°C, Luftfeuchtigkeit: {observable.Humidity}%");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"Fehler: {error.Message}");
    }

    public void OnCompleted()
    {
        Console.WriteLine("[Pull] Keine weiteren Daten.");
    }
}