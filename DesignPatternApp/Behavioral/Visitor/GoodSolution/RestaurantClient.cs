namespace ch.px.designpattern.Behavioral.Visitor.GoodSolution;

internal class RestaurantClient : Client
{
    public RestaurantClient(string name, string email) : base(name, email)
    {
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.VisitRestaurant(this);
    }
}
