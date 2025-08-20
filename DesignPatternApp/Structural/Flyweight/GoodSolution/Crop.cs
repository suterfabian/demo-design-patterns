namespace ch.px.designpattern.Structural.Flyweight.GoodSolution;
internal class Crop
{
    private readonly int _x;
    private readonly int _y;
    private readonly CropIcon _cropIcon;
    //private readonly CropType _cropType;
    //private readonly byte[]? _icon;

    public Crop(int x, int y, CropIcon cropIcon) //, CropType cropType, byte[]? icon
    {
        _x = x;
        _y = y;
        _cropIcon = cropIcon;
        //_cropType = cropType;
        //_icon = icon;
    }

    public void Render()
    {
        Console.WriteLine($"Drawing {_cropIcon.GetType()} at ({_x}, {_y}).");
    }
}
