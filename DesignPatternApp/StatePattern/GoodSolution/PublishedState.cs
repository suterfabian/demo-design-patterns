namespace ch.px.designpattern.StatePattern.GoodSolution;

internal class PublishedState : IState
{
    private Document _document;

    public PublishedState(Document document)
    {
        _document = document;
    }

    public void Publish()
    {
        // Do nothing, since this already is the highest state
    }
}