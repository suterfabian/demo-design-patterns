namespace ch.px.designpattern.TemplateMethod.StrategyPattern;

internal class Camomile : IBeverage
{
    public void Prepare()
    {
        Brew();
    }

    private void Brew()
    {
        Console.WriteLine("Brewing camomile for 4 minutes");
    }
}