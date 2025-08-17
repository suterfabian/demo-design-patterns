namespace ch.px.designpattern.Flyweight.GoodSolution;

// holds intrinsic or static state
internal class CropIcon
{
    private readonly CropType _cropType;
    private readonly byte[]? _icon;

    public CropIcon(CropType cropType, byte[]? icon)
    {
        _cropType = cropType;
        _icon = icon;
    }

    public new CropType GetType() => _cropType;
}
