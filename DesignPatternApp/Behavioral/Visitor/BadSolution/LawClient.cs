namespace ch.px.designpattern.Behavioral.Visitor.BadSolution;

internal class LawClient : Client
{
    public LawClient(string name, string email) : base(name, email)
    {
    }

    public override void SendEmail()
    {
        Console.WriteLine($"Sending Law Marketing Tipps via email to {_name}");
    }
}
