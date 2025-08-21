using ch.px.designpattern.Creational.FactoryMethod.GoodSolution.MVCFramework;

namespace ch.px.designpattern.Creational.FactoryMethod.GoodSolution;
internal class OrdersController : TwigController // Controller
{
    public void ListOrders()
    {
        // Simulate fetching users previous orders from db
        var orders = new Dictionary<string, object>
        {
            {"Red Socks", "CHF 12.95"},
            {"Black Socks", "CHF 10.00"},
            {"Blue Pullover", "CHF 35.50"}
        };

        Render("orders.php", orders);
    }

    public void GetOrder(int id)
    {
        var order = new Dictionary<string, object>
        {
            {"Red Socks", "CHF 12.95"},
        };

        Render("order.php", order);
    }
}
