namespace ch.px.designpattern.Structural.Facade.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Facade - Bad Solution");

        var orderRequest = new OrderRequest();

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

// Charging card with name Kaspar Knopf
// Inserting order into database
// Reducing inventory of Item-01 by 1
// Reducing inventory of Item-02 by 1
// Reducing inventory of Item-03 by 1
// Reducing inventory of Item-04 by 1