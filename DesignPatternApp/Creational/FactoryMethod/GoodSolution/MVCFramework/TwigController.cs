using ch.third.party.library.MVCFramework.GoodSolution;

namespace ch.px.designpattern.Creational.FactoryMethod.GoodSolution.MVCFramework;
internal class TwigController : Controller
{
    protected override IViewEngine CreateViewEngine()
    {
        return new TwigViewEngine();
    }
}
