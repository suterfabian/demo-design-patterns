namespace ch.px.designpattern.Structural.Decorator.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Decorator - Good Solution");

        var url = "https//www.protonx.ch";
        var data = "This is a very long sentence.";
        var validate = true;
        var compress = true;
        var encrypt = true;

        IData cloudData = new CloudData(url);

        if (compress)
        {
            cloudData = new CompressionDecorator(cloudData);
        }

        if (encrypt)
        {
            cloudData = new EncryptionDecorator(cloudData);
        }

        if (validate)
        {
            cloudData = new ValidationDecorator(cloudData);
        }

        cloudData.Save(data);
    }
}