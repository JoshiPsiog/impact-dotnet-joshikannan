using Week04_MVC_Pattern.Models;
using Week04_MVC_Pattern.Services;

namespace Week04_MVC_Pattern.Data;

public static class RepositoryDemo
{
    public static void Run()
    {
        IRepository<Student> repository =
            new InMemoryRepository<Student>(student => student.Id);

        IStudentService service = new StudentService(repository);

        service.AddStudent(new Student
        {
            Id = 1,
            Name = "Arun",
            Age = 20,
            RollNumber = "ST001",
            Email = "arun@example.com"
        });

        service.AddStudent(new Student
        {
            Id = 2,
            Name = "Priya",
            Age = 21,
            RollNumber = "ST002",
            Email = "priya@example.com"
        });

        Console.WriteLine("Students:");

        foreach (var student in service.GetAll())
        {
            Console.WriteLine(
                $"{student.Id} | {student.Name} | {student.RollNumber}");
        }

        var duplicate = new Student
        {
            Id = 3,
            Name = "Karthik",
            Age = 22,
            RollNumber = "ST001",
            Email = "karthik@example.com"
        };

        Console.WriteLine(
            $"\nDuplicate roll number accepted: {service.AddStudent(duplicate)}");

        try
        {
            var invalidAge = new Student
            {
                Id = 4,
                Name = "Test",
                Age = 101,
                RollNumber = "ST004",
                Email = "test@example.com"
            };


            Console.WriteLine(
                $"Invalid age accepted: {service.AddStudent(invalidAge)}");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid age accepted: False");
        }

        var emptyName = new Student
        {
            Id = 5,
            Name = "",
            Age = 20,
            RollNumber = "ST005",
            Email = "test@example.com"
        };

        Console.WriteLine(
            $"Empty name accepted: {service.AddStudent(emptyName)}");
    }
}