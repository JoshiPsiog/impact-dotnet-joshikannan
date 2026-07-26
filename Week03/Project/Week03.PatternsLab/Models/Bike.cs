using Week03.PatternsLab.Interfaces;

namespace Week03.PatternsLab.Models;

public class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Riding Bike");
    }
}