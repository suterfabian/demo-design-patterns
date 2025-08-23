namespace ch.px.designpattern.Behavioral.Visitor.GoodSolution;

internal abstract class Client
{
    private readonly string _name;
    private readonly string _email;

    public Client(string name, string email)
    {
        _name = name;
        _email = email;
    }

    public abstract void Accept(IVisitor visitor);

    public string GetEmail()
    {
        return _email;
    }
}
