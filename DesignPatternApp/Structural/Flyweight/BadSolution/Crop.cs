namespace ch.px.designpattern.Structural.Flyweight.BadSolution;
internal class Crop
{
    private readonly int _x;
    private readonly int _y;
    private readonly CropType _cropType;
    private readonly byte[]? _icon;

    public Crop(int x, int y, CropType cropType, byte[] icon)
    {
        _x = x;
        _y = y;
        _cropType = cropType;
        _icon = icon;
    }

    public void Render()
    {
        Console.WriteLine($"Drawing {_cropType} at ({_x}, {_y}).");
    }
}
