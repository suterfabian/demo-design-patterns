namespace ch.px.designpattern.Structural.Composite.GoodSolution;
internal class Keyboard : IItem
{
    private float _price { get; set; } = 20.00f;

    public float GetPrice()
    {
        return _price;
    }
}
