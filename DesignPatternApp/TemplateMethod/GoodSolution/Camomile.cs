namespace ch.px.designpattern.TemplateMethod.GoodSolution;

internal class Camomile : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Brewing camomile for 4 minutes");
    }
}