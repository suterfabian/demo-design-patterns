namespace ch.px.designpattern.Flyweight.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Flyweight - Good Solution");

        var cropService = new CropService(new CropIconFactory());

        foreach (var crop in cropService.GetCrops())
        {
            crop.Render();
        }
    }
}