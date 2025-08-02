namespace ch.px.designpattern.Mediator.GoodSolution;
internal class TextBox : UiControl
{
    private string _text = string.Empty;

    public TextBox(DialogBox owner) : base(owner)
    { }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
        _owner.Changed(this);
    }
}
