namespace ch.px.designpattern.Behavioral.StatePattern.GoodSolution;

internal class ModerationState : IState
{
    private Document _document;

    public ModerationState(Document document)
    {
        _document = document;
    }

    public void Publish()
    {
        if (_document.CurrentUserRole == UserRoles.Admin)
        {
            _document.DocumentState = new PublishedState(_document);
        }
    }
}