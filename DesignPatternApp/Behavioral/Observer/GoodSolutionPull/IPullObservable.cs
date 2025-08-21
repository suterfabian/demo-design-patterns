namespace ch.px.designpattern.Behavioral.Observer.GoodSolutionPull;

internal interface IPullObservable
{
    IDisposable Subscribe(IObserver<IPullObservable> observer);

    float Temperature { get; }
    float Humidity { get; }
}