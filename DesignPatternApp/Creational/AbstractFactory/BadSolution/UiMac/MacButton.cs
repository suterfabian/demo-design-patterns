namespace ch.px.designpattern.Creational.AbstractFactory.BadSolution.UiMac;

internal class MacButton : IButton
{
    public void Render() => Console.WriteLine("Mac: Render button");
}
