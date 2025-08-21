namespace ch.px.designpattern.Behavioral.Observer.GoodSolutionPull;

internal class Unsubscriber : IDisposable
{
    private readonly List<IObserver<IPullObservable>> _observers;
    private readonly IObserver<IPullObservable> _observer;

    public Unsubscriber(List<IObserver<IPullObservable>> observers, IObserver<IPullObservable> observer)
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