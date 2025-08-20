namespace ch.px.designpattern.Structural.Adapter.GoodSolution;
internal class RainbowColorAdapterInherited : Rainbow3rdPartyColor, IColor
{
    public void ApplyColor(Video video)
    {
        var options = "rainbow inherited with options";

        Setup(options);

        ExecuteColor(video);
    }
}
