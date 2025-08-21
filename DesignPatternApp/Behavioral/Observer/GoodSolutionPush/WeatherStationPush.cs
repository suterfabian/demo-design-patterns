namespace ch.px.designpattern.Behavioral.Observer.GoodSolutionPush;

internal class WeatherStationPush : IObservable<WeatherData>
{
    private readonly List<IObserver<WeatherData>> _observers = new();

    public IDisposable Subscribe(IObserver<WeatherData> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);

        return new Unsubscriber(_observers, observer);
    }

    public void SetMeasurements(float temperature, float humidity)
    {
        var data = new WeatherData { Temperature = temperature, Humidity = humidity };
        foreach (var observer in _observers)
        {
            observer.OnNext(data);
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

    private class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<WeatherData>> _observers;
        private readonly IObserver<WeatherData> _observer;

        public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}