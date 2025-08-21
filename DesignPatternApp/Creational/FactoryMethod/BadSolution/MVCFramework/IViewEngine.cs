namespace ch.third.party.library.MVCFramework.BadSolution;

internal interface IViewEngine
{
    string Render(string fileName, Dictionary<string, object> data);
}
