namespace ch.px.designpattern.Behavioral.ChainOfResponsibilty.BadSolution;

internal class Logger
{
    public void Log(HttpRequest request)
    {
        Console.WriteLine("Log");
    }
}