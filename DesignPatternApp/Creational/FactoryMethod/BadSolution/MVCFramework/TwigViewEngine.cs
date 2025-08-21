namespace ch.third.party.library.MVCFramework.BadSolution;

internal class TwigViewEngine : IViewEngine
{
    public string Render(string fileName, Dictionary<string, object> data)
    {
        return $"View Rendered from {fileName} by Twig.";
    }
}
