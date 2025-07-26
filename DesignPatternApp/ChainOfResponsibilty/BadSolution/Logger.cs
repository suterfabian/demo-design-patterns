namespace ch.px.designpattern.ChainOfResponsibilty.BadSolution;

internal class Logger
{
    public void Log(HttpRequest request)
    {
        Console.WriteLine("Log");
    }
}