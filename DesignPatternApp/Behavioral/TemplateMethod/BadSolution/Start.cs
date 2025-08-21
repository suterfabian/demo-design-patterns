namespace ch.px.designpattern.Behavioral.TemplateMethod.BadSolution;

internal static class Start
{
    public static void Run()
    {
        Console.WriteLine("Template Method Pattern - Bad Solution");

        var tea = new Tea();
        tea.MakeBeverage();

        var coffee = new Coffee();
        coffee.MakeBeverage();
    }
}