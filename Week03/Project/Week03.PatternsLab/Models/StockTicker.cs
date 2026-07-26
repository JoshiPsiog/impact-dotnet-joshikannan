using Week03.PatternsLab.Interfaces;

namespace Week03.PatternsLab.Models;

public class StockTicker
{
    private readonly List<IStockObserver> observers = new();

    public event Action<string>? StockPriceChanged;

    public void Subscribe(IStockObserver observer)
    {
        observers.Add(observer);
    }

    public void Notify(string stockName, decimal price)
    {
        foreach (var observer in observers)
        {
            observer.Update(stockName, price);
        }

        StockPriceChanged?.Invoke($"{stockName} changed to ${price}");
    }
}