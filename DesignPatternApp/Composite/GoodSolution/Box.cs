namespace ch.px.designpattern.Composite.GoodSolution;
internal class Box : IItem
{
    private List<IItem> _items = [];

    public void Add(IItem item)
    {
        _items.Add(item);
    }

    public float GetPrice()
    {
        return _items.Sum(i => i.GetPrice());

        //float total = 0f;

        //foreach (var item in _items)
        //{
        //    total += item.GetPrice();
        //}

        //return total;
    }
}
