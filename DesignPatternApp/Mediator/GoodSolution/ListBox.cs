namespace ch.px.designpattern.Mediator.GoodSolution;
internal class ListBox : UiControl
{
    private string _selection = string.Empty;

    public ListBox(DialogBox owner) : base(owner)
    { }

    public string GetSelection()
    {
        return _selection;
    }

    public void SetSelection(string selection)
    {
        _selection = selection;
        _owner.Changed(this);
    }
}
