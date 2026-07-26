using Week03.PatternsLab.Exceptions;
using Week03.PatternsLab.Models;

namespace Week03.PatternsLab.Services;

public class BankService
{
    public void Withdraw(BankAccount account, decimal amount)
    {
        if (amount > account.Balance)
        {
            decimal deficit = amount - account.Balance;
            throw new InsufficientFundsException(deficit);
        }

        account.Balance -= amount;

        Console.WriteLine($"Withdrawal Successful : ${amount}");
        Console.WriteLine($"Remaining Balance     : ${account.Balance}");
    }

    public void DemonstrateCatchOrder(string input)
    {
        try
        {
            int number = int.Parse(input);

            Console.WriteLine($"Parsed Number : {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException : {ex.Message}");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"OverflowException : {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General Exception : {ex.Message}");
        }
    }
}