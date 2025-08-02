namespace ch.px.designpattern.Observer.GoodSolutionPull;

internal interface IPullObservable
{
    IDisposable Subscribe(IObserver<IPullObservable> observer);

    float Temperature { get; }
    float Humidity { get; }
}