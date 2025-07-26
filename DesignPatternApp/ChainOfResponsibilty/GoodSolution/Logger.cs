namespace ch.px.designpattern.ChainOfResponsibilty.GoodSolution;

public class Logger : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Log");

        return false;
    }
}