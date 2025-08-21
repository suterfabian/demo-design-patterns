using ch.px.designpattern.Creational.Builder.GoodSolutionDirector.Components;

namespace ch.px.designpattern.Creational.Builder.GoodSolutionDirector;

internal class ManualBuilder : IBuilder
{
    private Manual? _manual;

    public ManualBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _manual = new();
    }

    public IBuilder SetCarType(CarType carType)
    {
        _manual!.CarType = carType;

        return this;
    }

    public IBuilder SetSeats(int seats)
    {
        _manual!.Seats = seats;

        return this;
    }

    public IBuilder SetEngine(Engine engine)
    {
        _manual!.Engine = engine;

        return this;
    }

    public IBuilder IsConvertible(bool isConvertible)
    {
        _manual!.IsConvertible = isConvertible;

        return this;
    }

    public IBuilder SetDashboard(Dashboard dashboard)
    {
        _manual!.Dashboard = dashboard;

        return this;
    }

    public IBuilder SetWheels(Wheels wheels)
    {
        _manual!.Wheels = wheels;

        return this;
    }

    public IBuilder SetGPSNavigator(GPSNavigator gpsNavigator)
    {
        _manual!.GPSNavigator = gpsNavigator;

        return this;
    }

    public Manual GetManual()
    {
        var manual = _manual!;
        Reset();
        return manual;
    }
}
