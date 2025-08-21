using ch.px.designpattern.Creational.Builder.GoodSolution.Components;

namespace ch.px.designpattern.Creational.Builder.GoodSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Builder - Good Solution");

        var carBuilder = new CarBuilder();
        carBuilder
            .SetCarType(CarType.Sports)
            .SetSeats(2)
            .SetEngine(new Engine())
            .IsConvertible(true)
            .SetDashboard(new Dashboard(hasRevCounter: true))
            .SetWheels(new Wheels(diameterInInches: 18));
        var sportsCar = carBuilder.GetCar();
        sportsCar.Fuel = 99;
        Console.WriteLine(sportsCar.Print());

        var manualBuilder = new ManualBuilder();
        manualBuilder
            .SetCarType(CarType.SUV)
            .SetSeats(5)
            .SetEngine(new Engine())
            .IsConvertible(true)
            .SetDashboard(new Dashboard(hasRevCounter: true))
            .SetWheels(new Wheels(diameterInInches: 20));
        var manualCar = manualBuilder.GetManual();
        Console.WriteLine(manualCar.Print());
    }
}