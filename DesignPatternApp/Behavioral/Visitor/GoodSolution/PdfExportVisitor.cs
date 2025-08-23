namespace ch.px.designpattern.Behavioral.Visitor.GoodSolution;

internal class PdfExportVisitor : IVisitor
{
    public void VisitLaw(LawClient lawClient)
    {
        Console.WriteLine($"Pdf export Law for {lawClient.GetEmail()}");
    }

    public void VisitRestaurant(RestaurantClient restaurantClient)
    {
        Console.WriteLine($"Pdf export Restaurant for {restaurantClient.GetEmail()}");
    }

    public void VisitRetail(RetailClient retailClient)
    {
        Console.WriteLine($"Pdf export Retail for {retailClient.GetEmail()}");
    }
}
