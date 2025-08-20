namespace ch.px.designpattern.Structural.Facade.GoodSolution;

// Request object containing user-submitted data
internal class OrderRequest
{
    public string Name { get; set; } = "Kaspar Knopf";
    public string CardNumber { get; set; } = "1234";
    public float Amount { get; set; } = 20.55f;
    public string Address { get; set; } = "Wobelstrasse 1, 8610 Uster";
    public string[] ItemsIds { get; set; } = { "Item-01", "Item-02", "Item-03", "Item-04" };
}
