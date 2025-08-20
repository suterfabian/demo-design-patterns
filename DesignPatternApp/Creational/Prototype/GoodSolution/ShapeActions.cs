namespace ch.px.designpattern.Creational.Prototype.GoodSolution;
internal class ShapeActions
{
    public IShape Clone(IShape shape)
    {
        var type = shape.GetType();
        Console.WriteLine($"Clone Shape {type}");

        return shape.Clone();
    }
}
