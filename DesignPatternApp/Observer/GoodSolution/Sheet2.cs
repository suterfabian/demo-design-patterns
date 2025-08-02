namespace ch.px.designpattern.Observer.GoodSolution;

internal class Sheet2 : IObserver
{
    private int _total;
    private DataSource _dataSource;

    public Sheet2(DataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public void Update()
    {
        _total = CalculateTotal(_dataSource.GetValues());
    }

    private static int CalculateTotal(List<int> values)
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