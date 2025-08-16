using ch.thirdPartyLibrary.Package.GoodSolution;

namespace ch.px.designpattern.Proxy.GoodSolution;
internal class YouTubeVideoProxy : IVideo
{
    private readonly string _videoId;
    private YouTubeVideo? _video;

    public YouTubeVideoProxy(string videoId)
    {
        _videoId = videoId;
    }

    public string GetVideoId()
    {
        return _videoId;
    }

    public void Render()
    {
        if (_video is null)
        {
            _video = new YouTubeVideo(_videoId);
        }

        _video.Render();
    }
}
