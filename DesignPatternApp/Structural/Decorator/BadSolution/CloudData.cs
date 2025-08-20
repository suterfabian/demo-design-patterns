﻿namespace ch.px.designpattern.Structural.Decorator.BadSolution;
internal class CloudData
{
    protected string _url;

    public CloudData(string url)
    {
        _url = url;
    }

    public virtual void Save(string data)
    {
        Console.WriteLine($"Saving data >>{data}<< to cloud at {_url}");
    }
}
