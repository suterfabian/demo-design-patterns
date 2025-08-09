namespace ch.px.designpattern.Composite.GoodSolution;
internal class Microphone : IItem
{
    private float _price { get; set; } = 10.00f;

    public float GetPrice()
    {
        return _price;
    }
}
