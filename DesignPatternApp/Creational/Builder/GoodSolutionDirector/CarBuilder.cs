using ch.px.designpattern.Creational.Builder.GoodSolutionDirector.Components;

namespace ch.px.designpattern.Creational.Builder.GoodSolutionDirector;

internal class CarBuilder : IBuilder
{
    private Car? _car;

    public CarBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _car = new();
    }

    public IBuilder SetCarType(CarType carType)
    {
        _car!.CarType = carType;

        return this;
    }

    public IBuilder SetSeats(int seats)
    {
        _car!.Seats = seats;

        return this;
    }

    public IBuilder SetEngine(Engine engine)
    {
        _car!.Engine = engine;

        return this;
    }

    public IBuilder IsConvertible(bool isConvertible)
    {
        _car!.IsConvertible = isConvertible;

        return this;
    }

    public IBuilder SetDashboard(Dashboard dashboard)
    {
        _car!.Dashboard = dashboard;

        return this;
    }

    public IBuilder SetWheels(Wheels wheels)
    {
        _car!.Wheels = wheels;

        return this;
    }

    public IBuilder SetGPSNavigator(GPSNavigator gpsNavigator)
    {
        _car!.GPSNavigator = gpsNavigator;

        return this;
    }

    public Car GetCar()
    {
        var car = _car!;
        Reset();
        return car;
    }
}
