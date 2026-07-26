using System;
using System.Collections.Generic;

//================ TASK 2.1 =================
class BankAccount
{
    private double balance;
    private List<string> history = new List<string>();

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            history.Add($"Deposit of {amount} rejected.");
            return;
        }

        balance += amount;
        history.Add($"Deposited: {amount}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            history.Add($"Withdrawal of {amount} rejected.");
            return;
        }

        if (amount > balance)
        {
            history.Add($"Withdrawal of {amount} rejected (Insufficient balance).");
            return;
        }

        balance -= amount;
        history.Add($"Withdrawn: {amount}");
    }

    public double GetBalance() => balance;

    public void PrintHistory()
    {
        Console.WriteLine("\nTransaction History");
        foreach (var item in history)
            Console.WriteLine(item);
    }
}

//================ TASK 2.2 =================
class Vehicle
{
    public string Make;
    public string Model;
    public int Year;

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        Console.WriteLine("Vehicle Constructor");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle : {Make} {Model} ({Year})");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors;

    public Car(string make, string model, int year, int doors)
        : base(make, model, year)
    {
        NumberOfDoors = doors;
        Console.WriteLine("Car Constructor");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Car : {Make} {Model} ({Year}) Doors:{NumberOfDoors}");
    }
}

class Bike : Vehicle
{
    public bool HasSidecar;

    public Bike(string make, string model, int year, bool sidecar)
        : base(make, model, year)
    {
        HasSidecar = sidecar;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Bike : {Make} {Model} Sidecar:{HasSidecar}");
    }
}

class ElectricCar : Car
{
    public int BatteryCapacity;

    public ElectricCar(string make, string model, int year, int doors, int battery)
        : base(make, model, year, doors)
    {
        BatteryCapacity = battery;
        Console.WriteLine("ElectricCar Constructor");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Electric Car : {Make} {Model} Battery:{BatteryCapacity} kWh");
    }
}

//================ TASK 2.3 =================
class Notification
{
    public virtual void Send()
    {
        Console.WriteLine("Sending Notification");
    }
}

class EmailNotification : Notification
{
    public sealed override void Send()
    {
        Console.WriteLine("Sending Email Notification");
    }
}

// Uncomment below class to observe compile-time error due to sealed override
/*
class SpecialEmailNotification : EmailNotification
{
    public override void Send()
    {
        Console.WriteLine("Special Email");
    }
}
*/

class SmsNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending SMS Notification");
    }
}

class PushNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending Push Notification");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== TASK 2.1 =====");

        BankAccount account = new BankAccount();

        account.Deposit(1000);
        account.Withdraw(300);
        account.Withdraw(900);
        account.Deposit(-100);

        Console.WriteLine($"Balance : {account.GetBalance()}");
        account.PrintHistory();

        Console.WriteLine("\n===== TASK 2.2 =====");

        Vehicle car = new Car("Toyota", "Fortuner", 2024, 4);
        Vehicle bike = new Bike("Yamaha", "R15", 2023, false);
        Vehicle ev = new ElectricCar("Tesla", "Model 3", 2025, 4, 75);

        car.DisplayInfo();
        bike.DisplayInfo();
        ev.DisplayInfo();

        Console.WriteLine("\n===== TASK 2.3 =====");

        Notification[] notifications =
        {
            new EmailNotification(),
            new SmsNotification(),
            new PushNotification()
        };

        foreach (var n in notifications)
            n.Send();

        Console.WriteLine("\nSealed Override:");
        Console.WriteLine("Uncomment 'SpecialEmailNotification' class to observe compile-time error.");
    }
}