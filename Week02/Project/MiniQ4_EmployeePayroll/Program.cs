using System;
using System.Collections.Generic;
using System.Linq;

interface ITaxable
{
    double CalculateTax();
}

abstract class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }

    protected Employee(string name, string department)
    {
        Name = name;
        Department = department;
    }

    public abstract double CalculateSalary();
}

class FullTimeEmployee : Employee, ITaxable
{
    public double MonthlySalary;

    public FullTimeEmployee(string name, string dept, double salary)
        : base(name, dept)
    {
        MonthlySalary = salary;
    }

    public override double CalculateSalary() => MonthlySalary;

    public double CalculateTax() => MonthlySalary * 0.10;
}

class PartTimeEmployee : Employee
{
    public int Hours;
    public double Rate;

    public PartTimeEmployee(string name, string dept, int hours, double rate)
        : base(name, dept)
    {
        Hours = hours;
        Rate = rate;
    }

    public override double CalculateSalary() => Hours * Rate;
}

class ContractEmployee : Employee
{
    public double ContractAmount;

    public ContractEmployee(string name, string dept, double amount)
        : base(name, dept)
    {
        ContractAmount = amount;
    }

    public override double CalculateSalary() => ContractAmount;
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new()
        {
            new FullTimeEmployee("John","IT",60000),
            new FullTimeEmployee("Alice","HR",50000),
            new PartTimeEmployee("Bob","IT",100,250),
            new ContractEmployee("David","Finance",45000)
        };

        double total = employees.Sum(e => e.CalculateSalary());

        Console.WriteLine("Employee Payroll");

        foreach (var e in employees)
            Console.WriteLine($"{e.Name} - {e.Department} - {e.CalculateSalary()}");

        Console.WriteLine($"\nTotal Payroll = {total}");

        Console.WriteLine("\nDepartment Wise");

        var groups = employees.GroupBy(e => e.Department);

        foreach (var g in groups)
            Console.WriteLine($"{g.Key} : {g.Sum(x => x.CalculateSalary())}");
    }
}