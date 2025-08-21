namespace ch.px.designpattern.Behavioral.Observer.GoodSolution;

internal abstract class Subject
{
    private List<IObserver> _observers = [];

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update();
        }
    }
}