namespace ch.px.designpattern.Behavioral.Visitor.GoodSolution;

internal class RetailClient : Client
{
    public RetailClient(string name, string email) : base(name, email)
    {
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.VisitRetail(this);
    }
}
