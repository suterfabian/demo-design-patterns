using System;

namespace ch.px.designpattern;

public static class Tools
{
    public static void Line() => Console.WriteLine(new string('-', 60));

    public static void FatLine() => Console.WriteLine(new string('=', 60));
}
