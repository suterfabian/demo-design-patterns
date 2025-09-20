using ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiCore;

namespace ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiWindows;

internal class WindowsCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Windows: Render checkbox");
}
