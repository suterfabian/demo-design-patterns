namespace ch.px.designpattern.Observer.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Observer - Bad Solution");

        DataSource dataSource = new();

        Sheet2 sheet2 = new();
        BarChart barChart = new();

        dataSource.AddDependent(sheet2);
        dataSource.AddDependent(barChart);

        dataSource.SetValues([5, 9, 3, 4]); // 21

        dataSource.SetValues([7, 3, 8, 4, 9]); // 31
    }
}