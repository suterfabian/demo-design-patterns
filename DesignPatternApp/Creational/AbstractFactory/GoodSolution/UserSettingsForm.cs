using ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiCore;

namespace ch.px.designpattern.Creational.AbstractFactory.GoodSolution;

internal class UserSettingsForm
{
    public void Render(IUiComponentFactory uiComponentFactory)
    {
        uiComponentFactory.CreateButton().Render();

        uiComponentFactory.CreateCheckbox().Render();
    }
}
