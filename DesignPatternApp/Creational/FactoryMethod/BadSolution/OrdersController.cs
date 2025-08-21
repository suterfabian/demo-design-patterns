using ch.third.party.library.MVCFramework.BadSolution;

namespace ch.px.designpattern.Creational.FactoryMethod.BadSolution;
internal class OrdersController : Controller
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

        Render("orders.blade.php", orders);
    }

    public void GetOrder(int id)
    {
        var order = new Dictionary<string, object>
        {
            {"Red Socks", "CHF 12.95"},
        };

        Render("order.blade.php", order);
    }
}
