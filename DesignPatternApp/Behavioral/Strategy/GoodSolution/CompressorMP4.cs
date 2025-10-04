﻿namespace ch.px.designpattern.Behavioral.Strategy.GoodSolution;

internal class CompressorMP4 : ICompressor
{
    public void Compress() => Console.WriteLine("Compressing using MP4");
}
