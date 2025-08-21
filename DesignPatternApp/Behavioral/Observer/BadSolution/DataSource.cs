namespace ch.px.designpattern.Behavioral.Observer.BadSolution;

internal class DataSource
{
    private List<int> _values = [];
    private List<object> _dependents = [];

    public List<int> GetValues()
    {
        return _values;
    }

    public void SetValues(List<int> values)
    {
        _values = values;

        foreach (var dependent in _dependents)
        {
            if (dependent is Sheet2)
            {
                (dependent as Sheet2)?.CalculateTotal(_values);
            }
            else if (dependent is BarChart)
            {
                (dependent as BarChart)?.Render(_values);
            }
        }
    }

    public void AddDependent(object dependent)
    {
        _dependents.Add(dependent);
    }

    public void RemoveDependent(object dependent)
    {
        _dependents.Remove(dependent);
    }
}