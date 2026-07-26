using Week03.PatternsLab.Interfaces;
using Week03.PatternsLab.Patterns;

namespace Week03.PatternsLab.Demos;

public static class FactoryDemo
{
    public static void Run()
    {
        Console.WriteLine("\n========== TASK 3.5 ==========\n");

        Console.WriteLine("Simple Factory");

        IVehicle car = VehicleFactory.CreateVehicle("car");
        IVehicle bike = VehicleFactory.CreateVehicle("bike");
        IVehicle truck = VehicleFactory.CreateVehicle("truck");

        car.Drive();
        bike.Drive();
        truck.Drive();

        Console.WriteLine("\nFactory Method");

        VehicleCreator carFactory = new CarFactory();
        VehicleCreator bikeFactory = new BikeFactory();

        IVehicle c = carFactory.CreateVehicle();
        IVehicle b = bikeFactory.CreateVehicle();

        c.Drive();
        b.Drive();
    }
}