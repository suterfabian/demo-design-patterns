namespace ch.px.designpattern.TemplateMethod.BadSolution;

internal class Coffee
{
    public void MakeBeverage()
    {
        BoilWater();
        PourWaterIntoCup();
        Brew();
        AddCondiments();
    }

    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    private void PourWaterIntoCup()
    {
        Console.WriteLine("Pouring water into cup");
    }

    private void Brew()
    {
        Console.WriteLine("Brewing tea for 5 minutes");
    }

    private void AddCondiments()
    {
        if (CustomerWantsCondiments())
        {
            Console.WriteLine("Adding cream to the coffee");
        }
        else
        {
            Console.WriteLine("No condiments");
        }
    }

    private bool CustomerWantsCondiments()
    {
        Console.WriteLine("Would you like cream to your coffee (y/n)?");
        var input = Console.ReadLine();
        return input?.ToLower() == "y";
    }
}