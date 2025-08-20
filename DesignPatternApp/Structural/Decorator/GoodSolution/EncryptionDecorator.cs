namespace ch.px.designpattern.Structural.Decorator.GoodSolution;

internal class EncryptionDecorator : DataDecorator
{
    public EncryptionDecorator(IData data) : base(data)
    {
    }

    public override void Save(string data)
    {
        var encrypted = Encrypt(data);

        _data.Save(encrypted);
    }

    public string Encrypt(string data)
    {
        Console.WriteLine($"Encrypt data {data}");

        return "54fsg4d5f2r5sfg45";
    }
}
