namespace ch.px.designpattern.Mediator.GoodSolution;
internal class Button : UiControl
{
    private bool _isEnabled;

    public Button(DialogBox owner) : base(owner)
    { }

    public bool IsEnabled()
    {
        return _isEnabled;
    }

    public void SetIsEnabled(bool isEnabled)
    {
        _isEnabled = isEnabled;
        _owner.Changed(this);
    }
}
