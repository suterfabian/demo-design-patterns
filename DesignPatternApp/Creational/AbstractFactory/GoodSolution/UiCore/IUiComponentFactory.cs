namespace ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiCore;

internal interface IUiComponentFactory
{
    IButton CreateButton();

    ICheckbox CreateCheckbox();
}
