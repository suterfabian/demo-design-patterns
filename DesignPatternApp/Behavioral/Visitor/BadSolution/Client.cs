namespace ch.px.designpattern.Behavioral.Visitor.BadSolution;

internal abstract class Client
{
    protected readonly string _name;
    protected readonly string _email;

    public Client(string name, string email)
    {
        _name = name;
        _email = email;
    }

    public abstract void SendEmail();
}
