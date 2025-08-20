namespace ch.px.designpattern.Structural.Facade.BadSolution;
internal class Payment
{
    private readonly string _name;

    private readonly string _cardNumber;

    private readonly float _amount;

    public Payment(string name, string cardNumber, float amount)
    {
        _name = name;
        _cardNumber = cardNumber;
        _amount = amount;
    }

    public void Pay()
    {
        Console.WriteLine($"Charging card with name {_name}");
    }
}
