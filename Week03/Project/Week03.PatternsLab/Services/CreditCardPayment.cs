using Week03.PatternsLab.Interfaces;

namespace Week03.PatternsLab.Services;

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid ${amount} using Credit Card.");
    }
}