namespace ch.px.designpattern.Adapter.GoodSolution.ThirdPartyLibrary;
internal class Rainbow3rdPartyColor
{
    public void Setup(string options)
    {
        Console.WriteLine($"Setting up rainbow filter and apply options: {options}");
    }

    public void ExecuteColor(Video video)
    {
        Console.WriteLine("Execute rainbow color to video.");
    }
}
