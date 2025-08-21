namespace ch.px.designpattern.Observer.BadSolution;

internal class Sheet2
{
    public int CalculateTotal(List<int> values)
    {
        var sum = 0;
        foreach (var value in values)
        {
            sum += value;
        }

        Console.WriteLine($"Total: {sum}");

        return sum;
    }
}