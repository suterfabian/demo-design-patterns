namespace ch.third.party.library.MVCFramework.GoodSolution;

internal interface IViewEngine
{
    string Render(string fileName, Dictionary<string, object> data);
}
