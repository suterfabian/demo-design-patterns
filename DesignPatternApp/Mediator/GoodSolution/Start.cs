namespace ch.px.designpattern.Mediator.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Mediator Pattern - Good Solution");

        var postDialogBox = new PostDialogBox();

        postDialogBox.SimulateUserInteraction();
    }
}
