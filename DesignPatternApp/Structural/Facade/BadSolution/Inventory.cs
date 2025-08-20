namespace ch.px.designpattern.Structural.Facade.BadSolution;
internal class Inventory
{
    public bool CheckInventory(string itemId)
    {
        return true;
    }

    public void ReduceInventory(string itemId, int amount)
    {
        Console.WriteLine($"Reducing inventory of {itemId} by {amount}");
    }
}
