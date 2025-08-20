namespace ch.px.designpattern.Structural.Composite.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Composite - Bad Solution");

        var package = new Box();

        var box1 = new Box();
        box1.Add(new Microphone());

        var box2 = new Box();
        box2.Add(new Keyboard());
        box2.Add(new Mouse());

        package.Add(box1);
        package.Add(box2);

        var total = package.CalculateTotalPrice();

        Console.WriteLine($"Total: {total}");
    }
}