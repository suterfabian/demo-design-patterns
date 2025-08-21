namespace ch.px.designpattern.Creational.FactoryMethod.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Factory Method Pattern - Good Solution");

        var ordersController = new OrdersController();
        ordersController.ListOrders();
        ordersController.GetOrder(1);
    }
}