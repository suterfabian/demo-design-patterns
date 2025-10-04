namespace ch.px.designpattern.Behavioral.Strategy.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Strategy - Good Solution");

        var compressorMOV = new CompressorMOV();
        var overlayBlur = new OverlayBlur();

        var videoStorage = new VideoStorage(compressorMOV, overlayBlur);

        videoStorage.Store("myVideoFileName");

        videoStorage.SetCompressor(new CompressorMP4());
        videoStorage.SetOverlay(new OverlayBlackAndWhite());

        videoStorage.Store("myVideoFileName");
    }
}