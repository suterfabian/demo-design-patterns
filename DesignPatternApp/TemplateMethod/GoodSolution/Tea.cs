namespace ch.px.designpattern.TemplateMethod.GoodSolution;

internal class Tea : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Brewing tea for 3 minutes");
    }

    protected override void AddCondiments()
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