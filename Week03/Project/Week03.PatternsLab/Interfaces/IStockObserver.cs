namespace Week03.PatternsLab.Interfaces;

public interface IStockObserver
{
    void Update(string stockName, decimal price);
}