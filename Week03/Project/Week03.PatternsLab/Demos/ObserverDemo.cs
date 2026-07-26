using Week03.PatternsLab.Models;

namespace Week03.PatternsLab.Demos;

public static class ObserverDemo
{
    public static void Run()
    {
        Console.WriteLine("\n========== TASK 3.6 ==========\n");

        StockTicker ticker = new();

        Investor john = new("John");
        Investor alice = new("Alice");
        Investor bob = new("Bob");

        Console.WriteLine("----- Custom Observer -----");

        ticker.Subscribe(john);
        ticker.Subscribe(alice);
        ticker.Subscribe(bob);

        ticker.Notify("Microsoft", 250);

        Console.WriteLine();

        Console.WriteLine("----- C# Events -----");

        ticker.StockPriceChanged += john.ReceiveNotification;
        ticker.StockPriceChanged += alice.ReceiveNotification;
        ticker.StockPriceChanged += bob.ReceiveNotification;

        ticker.Notify("Apple", 300);

        /*
         Custom Observer:
         - Manual Subscribe()
         - More control
         - Good for custom implementations

         C# Events:
         - Built into .NET
         - Easier to implement
         - Used heavily in Windows Forms, ASP.NET, WPF
        */
    }
}