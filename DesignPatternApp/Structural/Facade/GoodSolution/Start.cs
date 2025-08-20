namespace ch.px.designpattern.Structural.Facade.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Facade - Good Solution");

        var orderRequest = new OrderRequest();

        var orderService = new OrderService();
        orderService.Order(orderRequest);
    }
}