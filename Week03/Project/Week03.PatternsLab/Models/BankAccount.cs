namespace Week03.PatternsLab.Models;

public class BankAccount
{
    public string AccountNumber { get; set; }
    public string AccountHolder { get; set; }
    public decimal Balance { get; set; }

    public BankAccount(string accountNumber, string accountHolder, decimal balance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public void DisplayAccount()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Account Number : {AccountNumber}");
        Console.WriteLine($"Account Holder : {AccountHolder}");
        Console.WriteLine($"Balance        : ${Balance}");
        Console.WriteLine("----------------------------------");
    }
}