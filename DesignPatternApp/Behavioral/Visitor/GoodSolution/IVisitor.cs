namespace ch.px.designpattern.Behavioral.Visitor.GoodSolution;

internal interface IVisitor
{
    void VisitRetail(RetailClient retailClient);

    void VisitRestaurant(RestaurantClient restaurantClient);

    void VisitLaw(LawClient lawClient);
}
