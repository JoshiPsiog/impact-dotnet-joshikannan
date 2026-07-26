using Week03.PatternsLab.Interfaces;

namespace Week03.PatternsLab.Models;

public class Investor : IStockObserver
{
    public string Name { get; }

    public Investor(string name)
    {
        Name = name;
    }

    public void Update(string stockName, decimal price)
    {
        Console.WriteLine($"{Name} received update -> {stockName} : ${price}");
    }

    public void ReceiveNotification(string message)
    {
        Console.WriteLine($"{Name} received event -> {message}");
    }
}