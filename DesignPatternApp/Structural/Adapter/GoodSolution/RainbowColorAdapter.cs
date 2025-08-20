namespace ch.px.designpattern.Structural.Adapter.GoodSolution;
internal class RainbowColorAdapter : IColor
{
    private Rainbow3rdPartyColor _rainbow3rdPartyColor;

    public RainbowColorAdapter(Rainbow3rdPartyColor color)
    {
        _rainbow3rdPartyColor = color;
        var options = "rainbow options";
        _rainbow3rdPartyColor.Setup(options);
    }

    public void ApplyColor(Video video)
    {
        _rainbow3rdPartyColor.ExecuteColor(video);
    }
}
