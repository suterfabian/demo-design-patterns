namespace ch.px.designpattern.StatePattern.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("State Pattern - Bad Solution");

        var doc = new Document();
        doc.State = DocumentStates.Moderation;
        // Only Admin can bring the document to published state
        doc.CurrentUserRole = UserRoles.Admin;
        Console.WriteLine(doc.State);

        doc.Publish();

        Console.WriteLine(doc.State);
    }
}