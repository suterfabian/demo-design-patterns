namespace ch.px.designpattern.Behavioral.TemplateMethod.StrategyPattern;

internal class BeverageMaker
{
    private IBeverage _beverage;

    public BeverageMaker(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public void SetBeverage(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public void MakeBeverage()
    {
        // Common operations
        BoilWater();
        PourWaterIntoCup();

        // Unique operations
        _beverage.Prepare();
    }

    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    private void PourWaterIntoCup()
    {
        Console.WriteLine("Pouring water into cup");
    }
}