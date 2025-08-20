namespace ch.px.designpattern.Structural.Composite.GoodSolution;
internal class Mouse : IItem
{
    private float _price { get; set; } = 5.00f;

    public float GetPrice()
    {
        return _price;
    }
}
