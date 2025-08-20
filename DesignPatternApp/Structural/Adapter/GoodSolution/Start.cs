namespace ch.px.designpattern.Structural.Adapter.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Adapter - Good Solution");

        var videoEditor = new VideoEditor(new Video());
        videoEditor.ApplyColor(new MidnightColor());

        // ---------------------------------------------
        // Variante 1
        // With simple adapter
        // ---------------------------------------------
        Console.WriteLine("*** Variant with composition - prefered solution ***");
        // Rainbow is a color class from a 3rd-party library
        // videoEditor.ApplyColor(new Rainbow3rdPartyColor());
        var rainbow3rdParty = new Rainbow3rdPartyColor();

        // Uses the adapter
        var rainbowColor = new RainbowColorAdapter(rainbow3rdParty);

        videoEditor.ApplyColor(rainbowColor);

        // ---------------------------------------------
        // Variante 2
        // With inheritance
        // ---------------------------------------------
        Console.WriteLine("*** Variant with inheritance ***");

        // Uses the adapter
        var rainbowColorInherited = new RainbowColorAdapterInherited();
        videoEditor.ApplyColor(rainbowColor);
    }
}