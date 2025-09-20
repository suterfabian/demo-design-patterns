namespace ch.px.designpattern.Creational.AbstractFactory.BadSolution.UiWindows;

internal class WindowsCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Windows: Render checkbox");
}
