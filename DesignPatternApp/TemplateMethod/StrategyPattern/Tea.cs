namespace ch.px.designpattern.TemplateMethod.StrategyPattern;

internal class Tea : IBeverage
{
    public void Prepare()
    {
        Brew();
        AddCondiments();
    }

    private void Brew()
    {
        Console.WriteLine("Brewing tea for 3 minutes");
    }

    private void AddCondiments()
    {
        if (CustomerWantsCondiments())
        {
            Console.WriteLine("Adding lemon to the tea");
        }
        else
        {
            Console.WriteLine("No condiments");
        }
    }

    private bool CustomerWantsCondiments()
    {
        Console.WriteLine("Would you like lemon to your tea (y/n)?");
        var input = Console.ReadLine();
        return input?.ToLower() == "y";
    }
}