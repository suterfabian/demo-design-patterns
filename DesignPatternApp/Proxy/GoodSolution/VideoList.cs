using ch.thirdPartyLibrary.Package.GoodSolution;

namespace ch.px.designpattern.Proxy.GoodSolution;

internal class VideoList
{
    private readonly Dictionary<string, IVideo> _videoList = [];

    public void Add(IVideo video) =>
        _videoList.Add(video.GetVideoId(), video);

    public void Watch(string videoId)
    {
        var video = _videoList[videoId];
        video.Render();
    }
}
