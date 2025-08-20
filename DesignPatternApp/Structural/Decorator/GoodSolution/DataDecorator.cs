namespace ch.px.designpattern.Structural.Decorator.GoodSolution;

internal abstract class DataDecorator : IData
{
    protected IData _data;

    public DataDecorator(IData data)
    {
        _data = data;
    }

    public abstract void Save(string data);
}
