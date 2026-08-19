
using Week04_MVC_Pattern.Models;

namespace Week04_MVC_Pattern.Views;

public class TeacherView
{
    public void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("===== Teacher Management =====");
        Console.WriteLine("1. Add Teacher");
        Console.WriteLine("2. View All Teachers");
        Console.WriteLine("3. Update Teacher");
        Console.WriteLine("4. Delete Teacher");
        Console.WriteLine("0. Back");
        Console.Write("Enter your choice: ");
    }

    public Teacher PromptForTeacher()
    {
        Console.Write("Enter Id: ");
        int id = int.Parse(Console.ReadLine()!);

        Console.Write("Enter Name: ");
        string name = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter Email: ");
        string email = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter Designation: ");
        string designation = Console.ReadLine() ?? string.Empty;

        return new Teacher
        {
            Id = id,
            Name = name,
            Email = email,
            Designation = designation
        };
    }

    public int PromptForId()
    {
        Console.Write("Enter Teacher ID: ");
        return int.Parse(Console.ReadLine()!);
    }

    public void PrintTeachers(IEnumerable<Teacher> teachers)
    {
        Console.WriteLine();
        Console.WriteLine(
            $"{"ID",-5} {"Name",-20} {"Email",-30} {"Designation",-20}");

        Console.WriteLine(new string('-', 80));

        foreach (var teacher in teachers)
        {
            Console.WriteLine(
                $"{teacher.Id,-5} " +
                $"{teacher.Name,-20} " +
                $"{teacher.Email,-30} " +
                $"{teacher.Designation,-20}");
        }
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}