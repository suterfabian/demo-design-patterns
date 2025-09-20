using ch.px.designpattern.Creational.AbstractFactory.BadSolution.UiMac;
using ch.px.designpattern.Creational.AbstractFactory.BadSolution.UiWindows;

namespace ch.px.designpattern.Creational.AbstractFactory.BadSolution;

internal class UserSettingsForm
{
    public void Render(OperationSystemType os)
    {
        if (os == OperationSystemType.Windows)
        {
            new WindowsButton().Render();
            new WindowsCheckbox().Render();
        }
        else if (os == OperationSystemType.Mac)
        {
            new MacButton().Render();
            new MacCheckbox().Render();
        }
    }
}
