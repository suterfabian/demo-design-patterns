using ch.px.designpattern.Creational.Builder.BadSolution.Components;

namespace ch.px.designpattern.Creational.Builder.BadSolution;

public static class Start
{
    public static void Run()
    {
        Console.WriteLine("Builder - Bad Solution");

        var sportsCar = new Car
        (
            carType: CarType.Sports,
            seats: 2,
            engine: new Engine(),
            isConvertible: false,
            dashboard: new Dashboard(hasRevCounter: true),
            wheels: new Wheels(diameterInInches: 20),
            gpsNavigator: new GPSNavigator()
        );
        sportsCar.Fuel = 100;
        Console.WriteLine(sportsCar.Print());

        var suvCar = new Car
        (
            carType: CarType.SUV,
            seats: 5,
            engine: new Engine(),
            isConvertible: false,
            dashboard: new Dashboard(hasRevCounter: true),
            wheels: new Wheels(diameterInInches: 18),
            gpsNavigator: new GPSNavigator()
        );
        suvCar.Fuel = 60;
        Console.WriteLine(suvCar.Print());

        var sportsCarManual = new Manual
        (
            carType: CarType.Sports,
            seats: 2,
            engine: new Engine(),
            isConvertible: false,
            dashboard: new Dashboard(hasRevCounter: true),
            wheels: new Wheels(diameterInInches: 20),
            gpsNavigator: new GPSNavigator()
        );
        Console.WriteLine(sportsCarManual.Print());

        var suvCarManual = new Manual
        (
            carType: CarType.SUV,
            seats: 5,
            engine: new Engine(),
            isConvertible: false,
            dashboard: new Dashboard(hasRevCounter: true),
            wheels: new Wheels(diameterInInches: 18),
            gpsNavigator: new GPSNavigator()
        );
        Console.WriteLine(suvCarManual.Print());
    }
}