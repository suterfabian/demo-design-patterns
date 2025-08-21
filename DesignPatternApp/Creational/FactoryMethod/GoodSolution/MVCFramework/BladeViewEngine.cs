namespace ch.third.party.library.MVCFramework.GoodSolution;

internal class BladeViewEngine : IViewEngine
{
    public string Render(string fileName, Dictionary<string, object> data)
    {
        return $"View Rendered from {fileName} by Blade.";
    }
}
