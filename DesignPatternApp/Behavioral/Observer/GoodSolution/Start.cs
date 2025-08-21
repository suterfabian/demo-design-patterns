namespace ch.px.designpattern.Behavioral.Observer.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Observer - Good Solution");

        var dataSource = new DataSource();

        var barChart = new BarChart(dataSource);
        var sheet2 = new Sheet2(dataSource);

        dataSource.AddObserver(barChart);
        dataSource.AddObserver(sheet2);

        dataSource.SetValues([1, 2, 3, 4, 5]);

        dataSource.SetValues([10, 20, 30, 40, 50]);
    }
}
