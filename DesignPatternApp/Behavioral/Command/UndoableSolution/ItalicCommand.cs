namespace ch.px.designpattern.Behavioral.Command.UndoableSolution;

internal class ItalicCommand : IUndoableCommand
{
    private HtmlDocument _document;
    private History _history;

    private string _previousContent = string.Empty;

    public ItalicCommand(HtmlDocument document, History history)
    {
        _document = document;
        _history = history;
    }

    public void Execute()
    {
        _previousContent = _document.Content;
        _document.MakeItalic(); // delegating the work to the doc business object
        _history.Push(this);
    }

    public void Unexecute()
    {
        _document.Content = _previousContent;
    }
}
