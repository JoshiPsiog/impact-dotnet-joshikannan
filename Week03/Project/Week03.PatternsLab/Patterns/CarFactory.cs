using Week03.PatternsLab.Interfaces;
using Week03.PatternsLab.Models;

namespace Week03.PatternsLab.Patterns;

public class CarFactory : VehicleCreator
{
    public override IVehicle CreateVehicle()
    {
        return new Car();
    }
}