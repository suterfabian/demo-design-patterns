namespace ch.px.designpattern.Composite.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Composite - Good Solution");
        Console.WriteLine("Structural Desing Pattern");

        var package = new Box();

        var box1 = new Box();
        box1.Add(new Mouse());
        box1.Add(new Keyboard());

        var box2 = new Box();
        box2.Add(new Microphone());

        package.Add(box1);
        package.Add(box2);

        var total = package.GetPrice();

        Console.WriteLine($"Good Total: {total}");
    }
}