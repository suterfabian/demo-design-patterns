namespace ch.px.designpattern.Behavioral.ChainOfResponsibilty.GoodSolution;

public class LoggerHandler : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Log");

        return false;
    }
}