namespace ch.px.designpattern.Behavioral.Command.UndoableSolution;

internal class HtmlDocument
{
    public string Content { get; set; } = string.Empty;

    public void MakeItalic()
    {
        Content = $"<i>{Content}</i>";
    }
}
