namespace ch.px.designpattern.TemplateMethod.GoodSolution;

internal static class Start
{
    public static void Run()
    {
        Console.WriteLine("Template Method Pattern");

        // ========================================
        // Bad Solution
        // ========================================
        /*
        var tea = new BadTea();
        tea.MakeBeverage();

        var coffee = new BadCoffee();
        coffee.MakeBeverage();
        */
        // ========================================
        // Solution - Strategy Pattern
        // ========================================
        /*
        var beverageMaker = new BeverageMaker(new Tea());
        beverageMaker.MakeBeverage();

        beverageMaker.SetBeverage(new Coffee());
        beverageMaker.MakeBeverage();

        beverageMaker.SetBeverage(new Camomile());
        beverageMaker.MakeBeverage();
        */
        // ========================================
        // Good Solution - Template Method Pattern
        // ========================================

        var tea = new Tea();
        tea.Prepare();

        var camomile = new Camomile();
        camomile.Prepare();

        var coffee = new Coffee();
        coffee.Prepare();
    }
}