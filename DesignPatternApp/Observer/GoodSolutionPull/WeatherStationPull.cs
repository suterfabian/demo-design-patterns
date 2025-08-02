namespace ch.px.designpattern.Observer.GoodSolutionPull;

internal class WeatherStationPull : IPullObservable
{
    private readonly List<IObserver<IPullObservable>> _observers = new();

    public float Temperature { get; private set; }
    public float Humidity { get; private set; }

    public IDisposable Subscribe(IObserver<IPullObservable> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);

        return new Unsubscriber(_observers, observer);
    }

    public void SetMeasurements(float temperature, float humidity)
    {
        Temperature = temperature;
        Humidity = humidity;

        foreach (var observer in _observers)
        {
            observer.OnNext(this); // Nur Benachrichtigung – keine Daten
        }
    }

    public void EndTransmission()
    {
        foreach (var observer in _observers)
        {
            observer.OnCompleted();
        }
        _observers.Clear();
    }
}