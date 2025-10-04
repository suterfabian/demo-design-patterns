namespace ch.px.designpattern.Behavioral.Strategy.GoodSolution;

internal class OverlayBlackAndWhite : IOverlay
{
    public void Apply() => Console.WriteLine("Applying black and white overlay");
}
