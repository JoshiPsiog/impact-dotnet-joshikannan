using Week03.PatternsLab.Interfaces;
using Week03.PatternsLab.Models;

namespace Week03.PatternsLab.Patterns;

public static class VehicleFactory
{
    public static IVehicle CreateVehicle(string type)
    {
        return type.ToLower() switch
        {
            "car" => new Car(),
            "bike" => new Bike(),
            "truck" => new Truck(),
            _ => throw new ArgumentException("Invalid Vehicle")
        };
    }
}