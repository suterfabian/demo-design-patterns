namespace ch.px.designpattern.Creational.Prototype.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Prototype Pattern - Good Solution");

        var circle = new Circle();
        circle.Draw();

        circle.Radius = 12;

        var rectangle = new Rectangle();
        rectangle.Draw();

        rectangle.Width = 20;
        rectangle.Height = 15;

        // copy a shape
        var shapeActions = new ShapeActions();

        var newCircle = shapeActions.Clone(circle);
        newCircle.Draw();

        var newRectangle = shapeActions.Clone(rectangle);
        newRectangle.Draw();
    }
}