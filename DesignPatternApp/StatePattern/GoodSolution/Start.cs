namespace ch.px.designpattern.StatePattern.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("State Pattern - Good Solution");

        // Only Admin can bring the document to published state
        var doc = new Document(UserRoles.Admin);
        Console.WriteLine(doc.DocumentState);

        doc.Publish();
        Console.WriteLine(doc.DocumentState);

        doc.Publish();
        Console.WriteLine(doc.DocumentState);

        doc.DocumentState = new DraftState(doc);
        Console.WriteLine(doc.DocumentState);
    }
}