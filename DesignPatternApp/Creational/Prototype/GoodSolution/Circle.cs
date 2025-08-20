namespace ch.px.designpattern.Creational.Prototype.GoodSolution;
internal class Circle : IShape
{
    public int Radius { get; set; } = 5;

    public IShape Clone()
    {
        var newShape = new Circle();
        newShape.Radius = Radius;
        return newShape;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing Circle with R: {Radius}");
    }
}
