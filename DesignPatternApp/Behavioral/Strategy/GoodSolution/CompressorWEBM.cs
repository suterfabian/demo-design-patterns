namespace ch.px.designpattern.Behavioral.Strategy.GoodSolution;

internal class CompressorWEBM : ICompressor
{
    public void Compress() => Console.WriteLine("Compressing using WEBM");
}
