using ch.px.designpattern.Creational.Builder.GoodSolutionDirector.Components;

namespace ch.px.designpattern.Creational.Builder.GoodSolutionDirector;
internal class Director
{
    public void ConstructSportsCar(IBuilder builder)
    {
        builder
            .SetCarType(CarType.Sports)
            .SetSeats(2)
            .SetEngine(new Engine())
            .IsConvertible(true)
            .SetDashboard(new Dashboard(hasRevCounter: true))
            .SetWheels(new Wheels(diameterInInches: 18));
    }

    public void ConstructSuvCar(IBuilder builder)
    {
        builder
            .SetCarType(CarType.SUV)
            .SetSeats(5)
            .SetEngine(new Engine())
            .IsConvertible(true)
            .SetDashboard(new Dashboard(hasRevCounter: true))
            .SetGPSNavigator(new GPSNavigator())
            .SetWheels(new Wheels(diameterInInches: 24));
    }
}
