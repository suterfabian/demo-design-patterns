namespace ch.px.designpattern.Behavioral.State.GoodSolution;

internal class DraftState : IState
{
    private Document _document;

    public DraftState(Document document)
    {
        _document = document;
    }

    public void Publish()
    {
        _document.DocumentState = new ModerationState(_document);
    }
}