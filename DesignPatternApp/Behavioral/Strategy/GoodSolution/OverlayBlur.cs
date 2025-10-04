namespace ch.px.designpattern.Behavioral.Strategy.GoodSolution;

internal class OverlayBlur : IOverlay
{
    public void Apply() => Console.WriteLine("Applying blur overlay");
}
