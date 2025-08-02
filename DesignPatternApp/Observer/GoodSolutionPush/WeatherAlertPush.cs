namespace ch.px.designpattern.Observer.GoodSolutionPush;

internal class WeatherAlertPush : IObserver<WeatherData>
{
    public void OnNext(WeatherData observable)
    {
        if (observable.Temperature > 30)
        {
            Console.WriteLine("[AlertPush] WARNUNG: Hitzewelle erkannt!");
        }
        if (observable.Humidity > 80)
        {
            Console.WriteLine("[AlertPush] WARNUNG: Sehr hohe Luftfeuchtigkeit!");
        }
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"[AlertPush] Fehler: {error.Message}");
    }

    public void OnCompleted()
    {
        Console.WriteLine("[AlertPush] Überwachung beendet.");
    }
}
