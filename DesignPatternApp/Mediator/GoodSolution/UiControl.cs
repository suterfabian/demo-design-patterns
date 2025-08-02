namespace ch.px.designpattern.Mediator.GoodSolution;
internal class UiControl
{
    protected DialogBox _owner;

    public UiControl(DialogBox owner)
    {
        _owner = owner;
    }
}
