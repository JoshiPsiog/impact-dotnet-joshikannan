using Week04_MVC_Pattern.Models;

namespace Week04_MVC_Pattern.Views;

public class StudentView
{
    public void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("===== Student Management =====");
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. View All Students");
        Console.WriteLine("3. View Student By ID");
        Console.WriteLine("4. Update Student");
        Console.WriteLine("5. Delete Student");
        Console.WriteLine("6. View Transaction Log");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice: ");
    }

    public void PrintStudents(IEnumerable<Student> students)
    {
        Console.WriteLine();
        Console.WriteLine(
            $"{"ID",-5} {"Name",-20} {"Age",-5} {"Roll Number",-15} {"Email",-30}");

        Console.WriteLine(new string('-', 80));

        foreach (var student in students)
        {
            Console.WriteLine(
                $"{student.Id,-5} " +
                $"{student.Name,-20} " +
                $"{student.Age,-5} " +
                $"{student.RollNumber,-15} " +
                $"{student.Email,-30}");
        }
    }

    public Student PromptForStudent()
    {
        Console.Write("Enter Id: ");
        int id = int.Parse(Console.ReadLine()!);

        Console.Write("Enter Name: ");
        string name = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine()!);

        Console.Write("Enter Roll Number: ");
        string rollNumber = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter Email: ");
        string email = Console.ReadLine() ?? string.Empty;

        return new Student
        {
            Id = id,
            Name = name,
            Age = age,
            RollNumber = rollNumber,
            Email = email
        };
    }

    public int PromptForId()
    {
        Console.Write("Enter Student ID: ");
        return int.Parse(Console.ReadLine()!);
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    public void PrintTransactionLog(IEnumerable<string> transactions)
    {
        Console.WriteLine();
        Console.WriteLine("===== Transaction Log =====");

        foreach (var transaction in transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}
