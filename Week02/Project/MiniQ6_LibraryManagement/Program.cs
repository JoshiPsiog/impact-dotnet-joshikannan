using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    public bool IsAvailable { get; set; }
}

class Program
{
    static void Main()
    {
        List<Book> books = new()
        {
            new(){Title="C#",Author="John",Genre="Programming",Year=2020,IsAvailable=true},
            new(){Title="ASP.NET",Author="John",Genre="Programming",Year=2022,IsAvailable=true},
            new(){Title="SQL",Author="Mike",Genre="Database",Year=2018,IsAvailable=false},
            new(){Title="Java",Author="Tom",Genre="Programming",Year=2016,IsAvailable=true},
            new(){Title="Python",Author="Tom",Genre="Programming",Year=2023,IsAvailable=true},
            new(){Title="AI",Author="Sam",Genre="Technology",Year=2024,IsAvailable=true},
            new(){Title="ML",Author="Sam",Genre="Technology",Year=2021,IsAvailable=false},
            new(){Title="Cloud",Author="John",Genre="Technology",Year=2019,IsAvailable=true},
            new(){Title="Linux",Author="Mike",Genre="OS",Year=2012,IsAvailable=true},
            new(){Title="Networking",Author="David",Genre="Network",Year=2015,IsAvailable=false},
            new(){Title="Docker",Author="John",Genre="DevOps",Year=2021,IsAvailable=true},
            new(){Title="Kubernetes",Author="John",Genre="DevOps",Year=2023,IsAvailable=true},
            new(){Title="Azure",Author="Tom",Genre="Cloud",Year=2022,IsAvailable=true},
            new(){Title="AWS",Author="Tom",Genre="Cloud",Year=2020,IsAvailable=true},
            new(){Title="React",Author="John",Genre="Frontend",Year=2024,IsAvailable=true}
        };

        Console.WriteLine("Available Books by John");

        foreach (var b in books.Where(x => x.Author == "John" && x.IsAvailable))
            Console.WriteLine(b.Title);

        Console.WriteLine("\nGenre Count");

        foreach (var g in books.GroupBy(x => x.Genre))
            Console.WriteLine($"{g.Key} : {g.Count()}");

        Console.WriteLine("\nOldest Book");

        var oldest = books.OrderBy(x => x.Year).First();

        Console.WriteLine($"{oldest.Title} ({oldest.Year})");

        Console.WriteLine("\nBooks After 2010");

        foreach (var b in books.Where(x => x.Year > 2010).OrderBy(x => x.Title))
            Console.WriteLine($"{b.Title} - {b.Year}");
    }
}