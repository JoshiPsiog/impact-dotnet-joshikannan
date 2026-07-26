using Week03.PatternsLab.Interfaces;

namespace Week03.PatternsLab.Services;

public class UnitOfWork : IUnitOfWork
{
    public StudentRepository Students { get; } = new();

    public CourseRepository Courses { get; } = new();

    public void Save()
    {
        Console.WriteLine("\nChanges Saved Successfully.");
    }
}