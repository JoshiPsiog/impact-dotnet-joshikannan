using Week03.PatternsLab.Comparers;
using Week03.PatternsLab.Models;

namespace Week03.PatternsLab.Demos;

public static class SortingDemo
{
    public static void Run()
    {
        Console.WriteLine("\n========== TASK 3.14 ==========\n");

        List<Employee> employees =
        [
            new(){Id=1,Name="John",Salary=5000},
            new(){Id=2,Name="Alice",Salary=8000},
            new(){Id=3,Name="Bob",Salary=6500},
            new(){Id=4,Name="David",Salary=4500},
            new(){Id=5,Name="Emma",Salary=9000},
            new(){Id=6,Name="Chris",Salary=7000},
            new(){Id=7,Name="Frank",Salary=5500},
            new(){Id=8,Name="Grace",Salary=6000},
            new(){Id=9,Name="Helen",Salary=7500},
            new(){Id=10,Name="Ian",Salary=5200}
        ];

        Console.WriteLine("Sort By Salary");

        employees.Sort();

        foreach (var emp in employees)
            Console.WriteLine($"{emp.Name} - ${emp.Salary}");

        Console.WriteLine();

        Console.WriteLine("Sort By Name");

        employees.Sort(new EmployeeNameComparer());

        foreach (var emp in employees)
            Console.WriteLine($"{emp.Name} - ${emp.Salary}");
    }
}