namespace ch.px.designpattern.ChainOfResponsibilty.BadSolution;

internal class WebServer
{
    public void Handle(HttpRequest request)
    {
        var validator = new Validator();
        validator.Validate(request);

        var authenticator = new Authenticator();
        authenticator.Authenticate(request);

        var logger = new Logger();
        logger.Log(request);
    }
}