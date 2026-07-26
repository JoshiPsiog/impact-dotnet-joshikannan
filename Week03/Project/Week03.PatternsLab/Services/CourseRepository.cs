using Week03.PatternsLab.Interfaces;
using Week03.PatternsLab.Models;

namespace Week03.PatternsLab.Services;

public class CourseRepository : IRepository<Course>
{
    private readonly List<Course> courses = new();

    public void Add(Course entity)
    {
        courses.Add(entity);

        Console.WriteLine($"Course Added : {entity.Title}");
    }

    public void Delete(int id)
    {
        courses.RemoveAll(x => x.Id == id);
    }

    public IEnumerable<Course> GetAll()
    {
        return courses;
    }

    public Course? GetById(int id)
    {
        return courses.FirstOrDefault(x => x.Id == id);
    }

    public void Update(Course entity)
    {
        Console.WriteLine($"Course Updated : {entity.Title}");
    }
}