namespace ch.px.designpattern.Behavioral.Visitor.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Visitor Pattern - Good Solution");

        // Get list of clients (e.g. from a db)
        var clients = new List<Client>
        {
            new LawClient("Kaspar Knopf", "kaspar.knopf@heaven.org"),
            new RestaurantClient("Lena Lunte", "lena.lunte@heaven.org"),
            new RetailClient("Smirle Wankel", "smirle.wankel@heaven.org")
        };

        foreach (var client in clients)
        {
            // client.Accept(new EmailVisitor());
            client.Accept(new PdfExportVisitor());
        }
    }
}