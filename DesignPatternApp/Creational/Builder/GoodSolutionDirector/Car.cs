using ch.px.designpattern.Creational.Builder.GoodSolutionDirector.Components;
using System.Text;

namespace ch.px.designpattern.Creational.Builder.GoodSolutionDirector;
internal class Car
{
    public CarType? CarType { get; set; }
    public int Seats { get; set; }
    public Engine? Engine { get; set; }
    public bool IsConvertible { get; set; }
    public Dashboard? Dashboard { get; set; }
    public Wheels? Wheels { get; set; }
    public GPSNavigator? GPSNavigator { get; set; }

    // fields specific to this classe
    public double Fuel { get; set; }

    public Car() { }

    public string Print()
    {
        StringBuilder sb = new();
        string stringLine = new string('-', 24) + "\n";

        sb.Append(stringLine);
        sb.Append($"Car \n");
        sb.Append(stringLine);

        if (CarType is not null) sb.Append($"CarType: {CarType} \n");
        sb.Append($"Seats: {Seats} \n");
        if (Wheels is not null) sb.Append($"Wheels (diameter in inches): {Wheels.GetDiameterInInches()} \n");
        if (Engine is not null) sb.Append($"Engine: {Engine} \n");

        sb.Append($"GPS Navigator: ");
        if (GPSNavigator != null)
        {
            sb.Append($"Infos on GPS Navigator...\n");
        }
        else
        {
            sb.Append($"N/A\n");
        }
        sb.Append($"Fuel: {Fuel}\n");

        return sb.ToString();
    }
}
