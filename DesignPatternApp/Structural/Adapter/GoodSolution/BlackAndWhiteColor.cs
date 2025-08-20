namespace ch.px.designpattern.Structural.Adapter.GoodSolution;

internal class BlackAndWhiteColor : IColor
{
    public void ApplyColor(Video video)
    {
        Console.WriteLine("Applying black and white color to video.");
    }
}
