namespace ch.px.designpattern.Behavioral.Strategy.GoodSolution;

internal class CompressorMOV : ICompressor
{
    public void Compress() => Console.WriteLine("Compressing using MOV");
}
