using ch.px.designpattern.Creational.Builder.GoodSolutionDirector.Components;

namespace ch.px.designpattern.Creational.Builder.GoodSolutionDirector;

internal interface IBuilder
{
    void Reset();
    IBuilder SetCarType(CarType carType);
    IBuilder SetSeats(int seats);
    IBuilder SetEngine(Engine engine);
    IBuilder IsConvertible(bool isConvertible);
    IBuilder SetDashboard(Dashboard dashboard);
    IBuilder SetWheels(Wheels wheels);
    IBuilder SetGPSNavigator(GPSNavigator gPSNavigator);
}
