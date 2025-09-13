namespace ch.px.designpattern.Behavioral.Iterator.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Iterator - Bad Solution");

        var shoppingList = new ShoppingList();
        shoppingList.Push("Milk");
        shoppingList.Push("Eggs");
        shoppingList.Push("Bread");

        for (int i = 0; i < shoppingList.GetList().Count; i++)
        {
            var item = shoppingList.GetList()[i];
            Console.WriteLine(item);
        }
    }
}