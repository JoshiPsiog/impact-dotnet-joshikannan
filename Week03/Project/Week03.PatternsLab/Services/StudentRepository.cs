using Week03.PatternsLab.Interfaces;
using Week03.PatternsLab.Models;

namespace Week03.PatternsLab.Services;

public class StudentRepository : IRepository<Student>
{
    private readonly List<Student> students = new();

    public void Add(Student entity)
    {
        students.Add(entity);
        Console.WriteLine($"Student Added : {entity.Name}");
    }

    public void Delete(int id)
    {
        students.RemoveAll(x => x.Id == id);
    }

    public IEnumerable<Student> GetAll()
    {
        return students;
    }

    public Student? GetById(int id)
    {
        return students.FirstOrDefault(x => x.Id == id);
    }

    public void Update(Student entity)
    {
        Console.WriteLine($"Student Updated : {entity.Name}");
    }
}