namespace ch.px.designpattern.Structural.Decorator.GoodSolution;

internal class CompressionDecorator : DataDecorator
{
    public CompressionDecorator(IData data) : base(data)
    {
    }

    public override void Save(string data)
    {
        var compressed = Compress(data);

        _data.Save(compressed);
    }

    public string Compress(string data)
    {
        Console.WriteLine($"Compress data {data}");

        return data[..8];
    }
}
