using ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiCore;

namespace ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiMac;

internal class MacUiComponentFactory : IUiComponentFactory
{
    public IButton CreateButton() => new MacButton();

    public ICheckbox CreateCheckbox() => new MacCheckbox();
}
