namespace ch.px.designpattern.Behavioral.Visitor.GoodSolution;

internal class EmailVisitor : IVisitor
{
    public void VisitLaw(LawClient lawClient)
    {
        Console.WriteLine($"Sending Law Marketing Tipps via email to {lawClient.GetEmail()}");
    }

    public void VisitRestaurant(RestaurantClient restaurantClient)
    {
        Console.WriteLine($"Sending Restaurant Marketing Tipps via email to {restaurantClient.GetEmail()}");
    }

    public void VisitRetail(RetailClient retailClient)
    {
        Console.WriteLine($"Sending Retail Marketing Tipps via email to {retailClient.GetEmail()}");
    }
}
