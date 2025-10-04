namespace ch.px.designpattern.Behavioral.Strategy.BadSolution;

internal class VideoStorage
{
    private Compressors _compressor;
    private Overlays _overlay;

    public VideoStorage(Compressors compressor, Overlays overlay = Overlays.None)
    {
        _compressor = compressor;
        _overlay = overlay;
    }

    public void SetCompressor(Compressors compressor)
    {
        _compressor = compressor;
    }

    public void SetOverlay(Overlays overlay)
    {
        _overlay = overlay;
    }

    public void Store(string fileName)
    {
        // Compressor logic
        if (_compressor == Compressors.MOV)
        {
            Console.WriteLine("Compressing using MOV");
        }
        else if (_compressor == Compressors.MP4)
        {
            Console.WriteLine("Compressing using MP4");
        }
        else if (_compressor == Compressors.WEBM)
        {
            Console.WriteLine("Compressing using WEBM");
        }

        // Overlay logic
        if (_overlay == Overlays.BlackAndWhite)
        {
            Console.WriteLine("Applying black and white overlay");
        }
        else if (_overlay == Overlays.Blur)
        {
            Console.WriteLine("Applying blur overlay");
        }
        else if (_overlay == Overlays.None)
        {
            Console.WriteLine("Not applying an overlay");
        }

        Console.WriteLine($"Storing Video to: {fileName}");
    }
}
