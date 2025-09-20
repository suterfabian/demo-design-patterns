using ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiCore;

namespace ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiWindows;

internal class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("Windows: Render button");
}
