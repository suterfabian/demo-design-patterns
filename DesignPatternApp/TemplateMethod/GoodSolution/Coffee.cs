namespace ch.px.designpattern.TemplateMethod.GoodSolution;

internal class Coffee : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Brewing tea for 5 minutes");
    }

    protected override void AddCondiments()
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