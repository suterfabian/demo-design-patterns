namespace ch.px.designpattern.Creational.Prototype.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Prototype Pattern - Bad Solution");

        var circle = new Circle();
        circle.Draw();
        circle.Radius = 12;

        var rectangle = new Rectangle();
        rectangle.Draw();
        rectangle.Width = 20;
        rectangle.Height = 15;

        // copy a shape
        var shapeActions = new ShapeActions();
        shapeActions.Duplicate(circle);
        shapeActions.Duplicate(rectangle);
    }
}