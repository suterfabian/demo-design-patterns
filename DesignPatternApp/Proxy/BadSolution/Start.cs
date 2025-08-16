using ch.thirdPartyLibrary.Package.BadSolution;

namespace ch.px.designpattern.Proxy.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Proxy - Bad Solution");

        var videoList = new VideoList();
        String[] videoIds = { "video-01", "video-02", "video-03", "video-04", "video-05" };

        foreach (var videoId in videoIds)
        {
            videoList.Add(new YouTubeVideo(videoId));
        }

        videoList.Watch("video-02");
    }
}