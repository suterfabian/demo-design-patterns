namespace ch.px.designpattern.Creational.Singleton.GoodSolution;
internal static class Test
{
    public static void Run()
    {
        var settings = AppSettings.GetInstance();
        Console.WriteLine("AppName in Test: " + settings.Get("app_name"));
    }
}
