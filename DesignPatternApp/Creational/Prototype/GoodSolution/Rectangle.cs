namespace ch.px.designpattern.Creational.Prototype.GoodSolution;
internal class Rectangle : IShape
{
    public int Width { get; set; } = 10;
    public int Height { get; set; } = 5;

    public IShape Clone()
    {
        var newShape = new Rectangle();
        newShape.Width = Width;
        newShape.Height = Height;
        return newShape;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing Rectangle with W: {Width} and H: {Height}");
    }
}
