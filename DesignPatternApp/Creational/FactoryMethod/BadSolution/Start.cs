namespace ch.px.designpattern.Creational.FactoryMethod.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Factory Method Pattern - Bad Solution");

        var ordersController = new OrdersController();
        ordersController.ListOrders();
    }
}