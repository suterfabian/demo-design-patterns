namespace ch.px.designpattern.Flyweight.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Flyweight - Bad Solution");

        var cropService = new CropService();

        foreach (var crop in cropService.GetCrops())
        {
            crop.Render();
        }
    }
}