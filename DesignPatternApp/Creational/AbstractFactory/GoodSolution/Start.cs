using ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiCore;
using ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiMac;
using ch.px.designpattern.Creational.AbstractFactory.GoodSolution.UiWindows;

namespace ch.px.designpattern.Creational.AbstractFactory.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Abstract Factory - Good Solution");

        var os = OperationSystemType.Mac;

        IUiComponentFactory? uiComponentFactory = null;

        if (os == OperationSystemType.Windows)
        {
            uiComponentFactory = new WindowsUiComponentFactory();
        }
        else if (os == OperationSystemType.Mac)
        {
            uiComponentFactory = new MacUiComponentFactory();
        }

        if (uiComponentFactory is not null)
        {
            new UserSettingsForm().Render(uiComponentFactory);
        }
    }
}
