namespace ch.px.designpattern.Behavioral.ChainOfResponsibilty.GoodSolution;

public class WebServer
{
    private Handler _handler;

    // Erhält den ersten Handler in der Kette.
    public WebServer(Handler handler)
    {
        _handler = handler;
    }

    public void Handle(HttpRequest request)
    {
        _handler.Handle(request);
    }
}