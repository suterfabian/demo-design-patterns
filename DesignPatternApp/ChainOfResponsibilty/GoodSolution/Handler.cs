namespace ch.px.designpattern.ChainOfResponsibilty.GoodSolution;

public abstract class Handler
{
    private Handler? _nextHandler;

    public Handler SetNextHandler(Handler nextHandler)
    {
        _nextHandler = nextHandler;

        // Rückgabe des Handlers ermöglicht:
        // "h1.SetNext(h2).SetNext(h3)"

        return nextHandler;
    }

    public void Handle(HttpRequest request)
    {
        // Um weiterzukommen braucht es false
        // true sagt, dass die die Verarbeitungskette nun zu Ende ist
        if (DoHandle(request))
        {
            return;
        }

        if (_nextHandler != null)
        {
            _nextHandler.Handle(request);
        }
    }

    public abstract bool DoHandle(HttpRequest request);
}