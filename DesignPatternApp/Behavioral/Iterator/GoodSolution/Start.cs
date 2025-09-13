namespace ch.px.designpattern.Behavioral.Iterator.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Iterator - Good Solution");

        var shoppingList = new ShoppingList();
        shoppingList.Push("Milk");
        shoppingList.Push("Eggs");
        shoppingList.Push("Bread");

        var iterator = shoppingList.CreateIterator();

        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Current());
            iterator.Next();
        }
    }
}