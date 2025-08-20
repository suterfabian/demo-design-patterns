namespace ch.px.designpattern.Structural.Proxy.GoodSolution;

public class Start
{
    public static void Run()
    {
        Console.WriteLine("Proxy - Good Solution");

        var videoList = new VideoList();
        string[] videoIds = { "video-01", "video-02", "video-03", "video-04", "video-05" };

        foreach (var videoId in videoIds)
        {
            videoList.Add(new YouTubeVideoProxy(videoId));
        }

        videoList.Watch("video-02");
    }
}
