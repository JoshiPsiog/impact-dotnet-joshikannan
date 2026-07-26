using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//================ TASK 2.11 =================
class Repository<T> where T : class, new()
{
    private List<T> items = new();

    public void Add(T item) => items.Add(item);

    public void Update(int index, T item)
    {
        if (index >= 0 && index < items.Count)
            items[index] = item;
    }

    public void Delete(int index)
    {
        if (index >= 0 && index < items.Count)
            items.RemoveAt(index);
    }

    public List<T> GetAll() => items;
}

class Student
{
    public string Name { get; set; } = "";
    public override string ToString() => Name;
}

class Product
{
    public string Name { get; set; } = "";
    public override string ToString() => Name;
}

//================ TASK 2.12 =================
class NumberGenerator
{
    public static IEnumerable<int> GetEvenNumbers(int max)
    {
        for (int i = 2; i <= max; i += 2)
            yield return i;
    }
}

class Book
{
    public string Title { get; set; } = "";
}

class BookCollection : IEnumerable<Book>
{
    private List<Book> books = new();

    public void Add(Book b) => books.Add(b);

    public IEnumerator<Book> GetEnumerator()
    {
        foreach (var b in books.OrderBy(x => x.Title))
            yield return b;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

//================ TASK 2.13 =================
class Employee
{
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
    public double Salary { get; set; }
    public DateTime JoiningDate { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== TASK 2.11 =====");

        Repository<Student> studentRepo = new();
        studentRepo.Add(new Student { Name = "John" });
        studentRepo.Add(new Student { Name = "Alice" });

        Console.WriteLine("Students:");
        foreach (var s in studentRepo.GetAll())
            Console.WriteLine(s);

        Repository<Product> productRepo = new();
        productRepo.Add(new Product { Name = "Laptop" });
        productRepo.Add(new Product { Name = "Mouse" });

        Console.WriteLine("\nProducts:");
        foreach (var p in productRepo.GetAll())
            Console.WriteLine(p);

        Console.WriteLine("\nConstraint:");
        Console.WriteLine("where T : class, new() -> Reference type with parameterless constructor.");

        Console.WriteLine("\n===== TASK 2.12 =====");

        Console.WriteLine("Even Numbers:");

        foreach (var n in NumberGenerator.GetEvenNumbers(20))
            Console.Write(n + " ");

        Console.WriteLine("\n\nBooks:");

        BookCollection collection = new();

        collection.Add(new Book { Title = "C# Programming" });
        collection.Add(new Book { Title = "Algorithms" });
        collection.Add(new Book { Title = "ASP.NET Core" });

        foreach (var b in collection)
            Console.WriteLine(b.Title);

        Console.WriteLine("\n===== TASK 2.13 =====");

        List<Employee> employees = new()
        {
            new(){Name="John",Department="IT",Salary=60000,JoiningDate=new DateTime(2020,1,1)},
            new(){Name="Alice",Department="HR",Salary=45000,JoiningDate=new DateTime(2022,1,1)},
            new(){Name="Bob",Department="IT",Salary=70000,JoiningDate=new DateTime(2019,1,1)},
            new(){Name="David",Department="Finance",Salary=80000,JoiningDate=new DateTime(2018,5,1)},
            new(){Name="Eva",Department="HR",Salary=52000,JoiningDate=new DateTime(2021,7,1)},
            new(){Name="Sam",Department="IT",Salary=55000,JoiningDate=new DateTime(2023,2,1)},
            new(){Name="Tom",Department="Finance",Salary=90000,JoiningDate=new DateTime(2017,1,1)},
            new(){Name="Jerry",Department="IT",Salary=65000,JoiningDate=new DateTime(2020,5,1)},
            new(){Name="Rose",Department="HR",Salary=48000,JoiningDate=new DateTime(2022,3,1)},
            new(){Name="James",Department="Finance",Salary=75000,JoiningDate=new DateTime(2019,8,1)}
        };

        Console.WriteLine("\nSalary > 50000");

        var salaryFilter =
            from e in employees
            where e.Salary > 50000
            select e;

        foreach (var e in salaryFilter)
            Console.WriteLine($"{e.Name} - {e.Salary}");

        Console.WriteLine("\nMethod Syntax");

        employees
            .Where(e => e.Salary > 50000)
            .ToList()
            .ForEach(e => Console.WriteLine($"{e.Name} - {e.Salary}"));

        Console.WriteLine("\nOrder By Salary Desc");

        var ordered =
            from e in employees
            orderby e.Salary descending
            select e;

        foreach (var e in ordered)
            Console.WriteLine($"{e.Name} - {e.Salary}");

        Console.WriteLine("\nGroup By Department");

        var groups =
            from e in employees
            group e by e.Department into g
            select new
            {
                Department = g.Key,
                Count = g.Count(),
                AvgSalary = g.Average(x => x.Salary)
            };

        foreach (var g in groups)
            Console.WriteLine($"{g.Department} Count:{g.Count} Avg:{g.AvgSalary}");

        Console.WriteLine("\nAnonymous Type");

        var anonymous =
            from e in employees
            select new
            {
                e.Name,
                Experience = DateTime.Now.Year - e.JoiningDate.Year
            };

        foreach (var a in anonymous)
            Console.WriteLine($"{a.Name} - {a.Experience} Years");
    }
}