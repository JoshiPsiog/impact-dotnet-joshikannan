using Week03.PatternsLab.Services;

namespace Week03.PatternsLab.Demos;

public static class StrategyDemo
{
    public static void Run()
    {
        Console.WriteLine("\n========== TASK 3.7 ==========\n");

        ShoppingCart cart = new();

        Console.WriteLine("Using Credit Card");
        cart.SetPaymentStrategy(new CreditCardPayment());
        cart.Checkout(1500);

        Console.WriteLine();

        Console.WriteLine("Switching to UPI");
        cart.SetPaymentStrategy(new UpiPayment());
        cart.Checkout(1500);

        Console.WriteLine();

        Console.WriteLine("Switching to Net Banking");
        cart.SetPaymentStrategy(new NetBankingPayment());
        cart.Checkout(1500);
    }
}