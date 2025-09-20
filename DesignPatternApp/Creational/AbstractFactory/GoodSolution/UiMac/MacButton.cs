using ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiCore;

namespace ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiMac;

internal class MacButton : IButton
{
    public void Render() => Console.WriteLine("Mac: Render button");
}
