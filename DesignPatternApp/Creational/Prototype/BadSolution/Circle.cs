namespace ch.px.designpattern.Creational.Prototype.BadSolution;
internal class Circle : IShape
{
    public int Radius { get; set; } = 5;

    public void Draw()
    {
        Console.WriteLine($"Drawing Circle with R: {Radius}");
    }
}
