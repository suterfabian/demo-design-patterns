namespace ch.px.designpattern.Structural.Facade.GoodSolution;
internal class OrderService
{
    public void Order(OrderRequest orderRequest)
    {
        var auth = new Authenticate();

        var inventory = new Inventory();

        foreach (var id in orderRequest.ItemsIds)
        {
            inventory.CheckInventory(id);
        }

        var payment = new Payment(orderRequest.Name, orderRequest.CardNumber, orderRequest.Amount);
        payment.Pay();

        var orderFulfillment = new OrderFulfillment(inventory);
        orderFulfillment.Fulfill(orderRequest.Name, orderRequest.Address, orderRequest.ItemsIds);
    }
}
