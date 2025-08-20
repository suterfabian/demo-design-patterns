namespace ch.px.designpattern.Structural.Decorator.BadSolution;
internal class EncryptData : CloudData
{
    public EncryptData(string url) : base(url)
    {
    }

    public override void Save(string data)
    {
        var encrypted = Encrypt(data);

        base.Save(encrypted);
    }

    public string Encrypt(string data)
    {
        Console.WriteLine($"Encrypt data {data}");

        return "54fsg4d5f2r5sfg45";
    }
}
