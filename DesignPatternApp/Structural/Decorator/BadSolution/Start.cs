namespace ch.px.designpattern.Structural.Decorator.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Decorator - Bad Solution");

        var url = "https//www.protonx.ch";
        var data = "This is a very long sentence.";
        var compress = true;
        var encrypt = true;

        CloudData cloudData;

        if (compress && encrypt)
        {
            cloudData = new CompressedAndEncryptedData(url);
        }
        else if (compress)
        {
            cloudData = new CompressData(url);
        }
        else if (encrypt)
        {
            cloudData = new EncryptData(url);
        }
        else
        {
            cloudData = new CloudData(url);
        }

        cloudData.Save(data);
    }
}