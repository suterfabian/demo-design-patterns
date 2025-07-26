namespace ch.px.designpattern.TemplateMethod.StrategyPattern;

internal class Coffee : IBeverage
{
    public void Prepare()
    {
        Brew();
        AddCondiments();
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