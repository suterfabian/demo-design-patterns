namespace ch.px.designpattern.Structural.Decorator.BadSolution;
internal class CompressData : CloudData
{
    public CompressData(string url) : base(url)
    {
    }

    public override void Save(string data)
    {
        var compressed = Compress(data);

        base.Save(compressed);
    }

    public string Compress(string data)
    {
        Console.WriteLine($"Compress data {data}");

        return data[..8];
        // return data.Substring(0, 8);
    }
}
