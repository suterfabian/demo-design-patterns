namespace ch.px.designpattern.Structural.Decorator.GoodSolution;

internal class ValidationDecorator : DataDecorator
{
    public ValidationDecorator(IData data) : base(data)
    {
    }

    public override void Save(string data)
    {
        var validated = Validate(data);

        _data.Save(validated);
    }

    public string Validate(string data)
    {
        Console.WriteLine($"Validate data {data}");

        return data[..8];
    }
}
