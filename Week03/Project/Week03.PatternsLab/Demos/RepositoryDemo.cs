using Week03.PatternsLab.Models;
using Week03.PatternsLab.Services;

namespace Week03.PatternsLab.Demos;

public static class RepositoryDemo
{
    public static void Run()
    {
        Console.WriteLine("\n========== TASK 3.8 ==========\n");

        UnitOfWork unitOfWork = new();

        unitOfWork.Students.Add(new Student
        {
            Id = 1,
            Name = "Joshikannan"
        });

        unitOfWork.Courses.Add(new Course
        {
            Id = 1,
            Title = "C#"
        });

        unitOfWork.Save();

        Console.WriteLine("\nStudents");

        foreach (Student student in unitOfWork.Students.GetAll())
        {
            Console.WriteLine($"{student.Id} - {student.Name}");
        }

        Console.WriteLine("\nCourses");

        foreach (Course course in unitOfWork.Courses.GetAll())
        {
            Console.WriteLine($"{course.Id} - {course.Title}");
        }
    }
}