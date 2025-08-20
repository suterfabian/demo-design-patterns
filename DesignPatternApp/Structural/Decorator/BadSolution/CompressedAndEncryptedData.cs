namespace ch.px.designpattern.Structural.Decorator.BadSolution;
internal class CompressedAndEncryptedData : CloudData
{
    public CompressedAndEncryptedData(string url) : base(url)
    {
    }

    public override void Save(string data)
    {
        var compressed = new CompressData(_url).Compress(data);
        var encrypted = new EncryptData(_url).Encrypt(data);

        base.Save(encrypted);
    }
}
