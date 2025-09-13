namespace ch.px.designpattern.Behavioral.Command.UndoableSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Command Pattern - Undoable Solution");

        var htmlDocument = new HtmlDocument();
        var history = new History();

        htmlDocument.Content = "Hello World";
        Console.WriteLine(htmlDocument.Content); // Hello World

        var italicCommand = new ItalicCommand(htmlDocument, history);
        italicCommand.Execute();
        Console.WriteLine(htmlDocument.Content); // <i>Hello World</i>

        var undoCommand = new UndoCommand(history);
        undoCommand.Execute();
        Console.WriteLine(htmlDocument.Content); // Hello World
    }
}