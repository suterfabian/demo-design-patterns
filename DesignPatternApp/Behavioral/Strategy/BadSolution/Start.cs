namespace ch.px.designpattern.Behavioral.Strategy.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Strategy - Bad Solution");

        var compressor = Compressors.MOV;
        var overlay = Overlays.Blur;

        var videoStorage = new VideoStorage(compressor, overlay);

        videoStorage.Store("myVideo");

        videoStorage.SetCompressor(Compressors.MP4);
        videoStorage.SetOverlay(Overlays.BlackAndWhite);

        videoStorage.Store("myVideo");
    }
}