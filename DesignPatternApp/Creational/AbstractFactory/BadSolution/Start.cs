namespace ch.px.designpattern.Creational.AbstractFactory.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Abstract Factory - Bad Solution");

        var os = OperationSystemType.Windows;

        var userSettingsForm = new UserSettingsForm();
        userSettingsForm.Render(os);
    }
}