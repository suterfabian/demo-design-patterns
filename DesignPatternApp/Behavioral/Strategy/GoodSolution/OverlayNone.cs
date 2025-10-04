namespace ch.px.designpattern.Behavioral.Strategy.GoodSolution;

internal class OverlayNone : IOverlay
{
    public void Apply() => Console.WriteLine("Not applying an overlay");
}
