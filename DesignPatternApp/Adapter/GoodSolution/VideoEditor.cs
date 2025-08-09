namespace ch.px.designpattern.Adapter.GoodSolution;
internal class VideoEditor
{
    private Video _video;

    public VideoEditor(Video video)
    {
        _video = video;
    }

    public void ApplyColor(IColor color)
    {
        color.ApplyColor(_video);
    }
}
