namespace ch.px.designpattern.ChainOfResponsibilty.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Chain Of Responsibilty Pattern - Bad Solution");

        var server = new WebServer();
        var request = new HttpRequest("kaspar", "123");
        server.Handle(request);
    }
}