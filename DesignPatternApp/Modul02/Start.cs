namespace ch.px.designpattern.Modul02;

public static class Start
{
    public static void Run()
    {
        Tools.FatLine();

        Console.WriteLine("Memento Patter (Behavioral Pattern)");
        Console.WriteLine("The Memento Pattern is used to restore an object to a previous state.");
        Tools.Line();

        var editor = new Editor();
        var history = new History(editor);

        editor.Title = "Title 01";
        editor.Content = "Content 01";
        history.Backup();
        editor.Title = "Title 02";
        editor.Content = "Content 02";
        history.Backup();
        editor.Title = "Title 03";
        editor.Content = "Content 03";
        history.Backup();

        Console.WriteLine($"Title: {editor.Title}");
        Console.WriteLine($"Content: {editor.Content}");

        history.ShowHistory();

        Tools.Line();

        editor.Title = "Title 04";
        editor.Content = "Content 04";
        Console.WriteLine($"Title: {editor.Title}");
        Console.WriteLine($"Content: {editor.Content}");

        Tools.Line();

        history.Undo();
        Console.WriteLine($"Title: {editor.Title}");
        Console.WriteLine($"Content: {editor.Content}");
        history.ShowHistory();

        Tools.Line();

        history.Undo();
        Console.WriteLine($"Title: {editor.Title}");
        Console.WriteLine($"Content: {editor.Content}");
        history.ShowHistory();
    }
}

