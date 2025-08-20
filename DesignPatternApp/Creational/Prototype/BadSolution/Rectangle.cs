namespace ch.px.designpattern.Creational.Prototype.BadSolution;
internal class Rectangle : IShape
{
    public int Width { get; set; } = 10;
    public int Height { get; set; } = 5;

    public void Draw()
    {
        Console.WriteLine($"Drawing Rectangle with W: {Width} and H: {Height}");
    }
}
