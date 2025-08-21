using ch.px.designpattern.Creational.Builder.BadSolution.Components;
using System.Text;

namespace ch.px.designpattern.Creational.Builder.BadSolution;
internal class Manual // Auto mit Schaltgetriebe
{
    public CarType _carType;
    public int _seats;
    public Engine _engine;
    public bool _isConvertible;
    public Dashboard _dashboard;
    public Wheels _wheels;
    public GPSNavigator _gpsNavigator;

    public Manual(
        CarType carType,
        int seats,
        Engine engine,
        bool isConvertible,
        Dashboard dashboard,
        Wheels wheels,
        GPSNavigator gpsNavigator)
    {
        _carType = carType;
        _seats = seats;
        _engine = engine;
        _isConvertible = isConvertible;
        _dashboard = dashboard;
        _wheels = wheels;
        _gpsNavigator = gpsNavigator;
    }

    public string Print()
    {
        StringBuilder sb = new();
        string stringLine = new string('-', 24) + "\n";

        sb.Append(stringLine);
        sb.Append($"Manual \n");
        sb.Append(stringLine);
        sb.Append($"CarType: {_carType} \n");
        sb.Append($"Seats: {_seats} \n");
        sb.Append($"Wheels (diameter in inches): {_wheels.GetDiameterInInches()} \n");
        sb.Append($"Engine: {_engine} \n");
        sb.Append($"GPS Navigator:\n");
        if (_gpsNavigator != null)
        {
            sb.Append($"Infos on GPS Navigator...\n");
        }
        else
        {
            sb.Append($"N/A\n");
        }

        return sb.ToString();
    }
}
