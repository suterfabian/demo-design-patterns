namespace ch.px.designpattern.Creational.Singleton.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Singleton - Bad Solution");

        var settings = new AppSettings();
        settings.Set("app_name", "Design Patterns");
        settings.Set("app_creator", "Kaspar Knopf");

        Console.WriteLine(settings.Get("app_name"));

        Test.Run();
    }
}