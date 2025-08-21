namespace ch.px.designpattern.Creational.Singleton.BadSolution;
internal static class Test
{
    public static void Run()
    {
        var settings = new AppSettings();
        Console.WriteLine("AppName in Test: " + settings.Get("app_name"));
    }
}
