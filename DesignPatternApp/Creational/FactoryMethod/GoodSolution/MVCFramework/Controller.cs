namespace ch.third.party.library.MVCFramework.GoodSolution;

internal class Controller
{
    public void Render(string fileName, Dictionary<string, object> data)
    {
        var viewEngine = CreateViewEngine();
        var html = viewEngine.Render(fileName, data);

        Console.WriteLine(html);
    }

    protected virtual IViewEngine CreateViewEngine()
    {
        return new BladeViewEngine();
    }
}
