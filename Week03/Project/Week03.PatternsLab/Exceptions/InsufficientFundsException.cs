namespace Week03.PatternsLab.Exceptions;

public class InsufficientFundsException : Exception
{
    public decimal DeficitAmount { get; }

    public InsufficientFundsException(decimal deficitAmount)
        : base($"Insufficient funds. You need ${deficitAmount} more.")
    {
        DeficitAmount = deficitAmount;
    }
}