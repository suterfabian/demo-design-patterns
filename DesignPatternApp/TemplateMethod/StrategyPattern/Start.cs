namespace ch.px.designpattern.TemplateMethod.StrategyPattern;

internal static class Start
{
    public static void Run()
    {
        Console.WriteLine("Template Method Pattern - Strategy Pattern Solution");

        var tea = new Tea();
        tea.Prepare();

        var camomile = new Camomile();
        camomile.Prepare();

        var coffee = new Coffee();
        coffee.Prepare();
    }
}