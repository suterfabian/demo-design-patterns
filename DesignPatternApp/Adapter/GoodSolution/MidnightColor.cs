namespace ch.px.designpattern.Adapter.GoodSolution;
internal class MidnightColor : IColor
{
    public void ApplyColor(Video video)
    {
        Console.WriteLine("Applying midnight color to video.");
    }
}
