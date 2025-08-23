namespace ch.px.designpattern.Behavioral.ChainOfResponsibilty.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Chain Of Responsibilty Pattern - Good Solution");

        var validator = new ValidatorHandler();
        var authenticator = new AuthenticatorHandler();
        var logger = new LoggerHandler();

        validator
            .SetNextHandler(authenticator)
            .SetNextHandler(logger);

        var webServer = new WebServer(validator);

        var request = new HttpRequest("kaspar", "123");

        webServer.Handle(request);
    }
}