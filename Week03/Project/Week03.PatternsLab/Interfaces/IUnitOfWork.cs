using Week03.PatternsLab.Services;

namespace Week03.PatternsLab.Interfaces;

public interface IUnitOfWork
{
    StudentRepository Students { get; }

    CourseRepository Courses { get; }

    void Save();
}