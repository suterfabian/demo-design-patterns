namespace ch.px.designpattern.Creational.Builder.GoodSolutionDirector;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Builder - Good Solution Director");

        var carBuilder = new CarBuilder();
        var director = new Director();

        director.ConstructSportsCar(carBuilder);
        var sportsCar = carBuilder.GetCar();
        sportsCar.Fuel = 98;
        Console.WriteLine(sportsCar.Print());

        director.ConstructSuvCar(carBuilder);
        var suvCar = carBuilder.GetCar();
        suvCar.Fuel = 90;
        Console.WriteLine(suvCar.Print());

        var manualBuilder = new ManualBuilder();
        director.ConstructSportsCar(manualBuilder);
        var sportsManual = manualBuilder.GetManual();
        Console.WriteLine(sportsManual.Print());

        director.ConstructSuvCar(manualBuilder);
        var suvManual = manualBuilder.GetManual();
        Console.WriteLine(suvManual.Print());
    }
}