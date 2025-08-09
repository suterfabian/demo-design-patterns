using ch.px.designpattern.Adapter.GoodSolution.ThirdPartyLibrary;

namespace ch.px.designpattern.Adapter.GoodSolution;
internal class RainbowColorAdapterInherited : Rainbow3rdPartyColor, IColor
{
    public void ApplyColor(Video video)
    {
        var options = "rainbow inherited with options";

        Setup(options);

        ExecuteColor(video);
    }
}
