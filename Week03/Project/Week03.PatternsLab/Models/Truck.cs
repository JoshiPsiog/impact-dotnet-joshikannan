using Week03.PatternsLab.Interfaces;

namespace Week03.PatternsLab.Models;

public class Truck : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving Truck");
    }
}