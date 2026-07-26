using Week03.PatternsLab.Exceptions;
using Week03.PatternsLab.Models;
using Week03.PatternsLab.Services;

namespace Week03.PatternsLab.Demos;

public static class ExceptionDemo
{
    public static void Run()
    {
        Console.WriteLine("========== TASK 3.1 ==========\n");

        BankAccount account =
            new BankAccount("ACC1001", "Joshikannan", 500);

        BankService bankService = new();

        account.DisplayAccount();

        Console.WriteLine("\nAttempting Withdrawal of $700...\n");

        try
        {
            bankService.Withdraw(account, 700);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine("Custom Exception Caught");
            Console.WriteLine(ex.Message);
            Console.WriteLine($"Deficit Amount : ${ex.DeficitAmount}");
        }
        finally
        {
            Console.WriteLine("\nWithdrawal attempt logged successfully.");
        }

        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine("Catch Order Demonstration");
        Console.WriteLine("----------------------------------------");

        bankService.DemonstrateCatchOrder("ABC");
        bankService.DemonstrateCatchOrder("99999999999999999999999999");
        bankService.DemonstrateCatchOrder("123");
    }
}