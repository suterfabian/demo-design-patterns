namespace ch.px.designpattern.Creational.Singleton.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Singleton - Good Solution");

        var settings = AppSettings.GetInstance();
        settings.Set("app_name", "Design Patterns");
        settings.Set("app_creator", "Kaspar Knopf");

        Console.WriteLine(settings.Get("app_name"));

        Test.Run();
    }
}