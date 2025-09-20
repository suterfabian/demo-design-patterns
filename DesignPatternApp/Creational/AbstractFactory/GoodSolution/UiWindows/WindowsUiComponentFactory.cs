using ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiCore;

namespace ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiWindows;

internal class WindowsUiComponentFactory : IUiComponentFactory
{
    public IButton CreateButton() => new WindowsButton();

    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}
