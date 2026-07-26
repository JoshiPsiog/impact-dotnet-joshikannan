using Week03.PatternsLab.Interfaces;

namespace Week03.PatternsLab.Services;

public class ShoppingCart
{
    private IPaymentStrategy? _paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void Checkout(decimal amount)
    {
        if (_paymentStrategy == null)
        {
            Console.WriteLine("No Payment Strategy Selected.");
            return;
        }

        _paymentStrategy.Pay(amount);
    }
}