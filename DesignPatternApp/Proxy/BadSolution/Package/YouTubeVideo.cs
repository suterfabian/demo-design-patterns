namespace ch.thirdPartyLibrary.Package.BadSolution;

internal class YouTubeVideo : IVideo
{
    private readonly string _videoId;

    public YouTubeVideo(string videoId)
    {
        _videoId = videoId;

        Downlod();
    }

    public string GetVideoId()
    {
        return _videoId;
    }

    public void Render()
    {
        Console.WriteLine($"Render video with Id: {_videoId}");
    }

    private void Downlod()
    {
        Console.WriteLine($"Download video with Id: {_videoId} from YouTube API");
    }
}
