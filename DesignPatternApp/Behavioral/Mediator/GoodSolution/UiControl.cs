namespace ch.px.designpattern.Behavioral.Mediator.GoodSolution;
internal class UiControl
{
    protected DialogBox _owner;

    public UiControl(DialogBox owner)
    {
        _owner = owner;
    }
}
