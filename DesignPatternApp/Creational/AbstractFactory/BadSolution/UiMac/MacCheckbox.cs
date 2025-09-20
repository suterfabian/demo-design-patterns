namespace ch.px.designpattern.Creational.AbstractFactory.BadSolution.UiMac;

internal class MacCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Mac: Render checkbox");
}
