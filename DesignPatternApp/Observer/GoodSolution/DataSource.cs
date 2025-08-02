namespace ch.px.designpattern.Observer.GoodSolution;

internal class DataSource : Subject
{
    private List<int> _values = [];

    public List<int> GetValues()
    {
        return _values;
    }

    public void SetValues(List<int> values)
    {
        _values = values;

        NotifyObservers();
    }
}