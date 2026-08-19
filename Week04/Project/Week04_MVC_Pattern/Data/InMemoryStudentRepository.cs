using Week04_MVC_Pattern.Models;

namespace Week04_MVC_Pattern.Data;

public class InMemoryStudentRepository : IRepository<Student>
{
    private readonly List<Student> _students = new();

    public Student Add(Student entity)
    {
        _students.Add(entity);
        return entity;
    }

    public IEnumerable<Student> GetAll()
    {
        return _students;
    }

    public Student? GetById(int id)
    {
        return _students.FirstOrDefault(s => s.Id == id);
    }

    public bool Update(Student entity)
    {
        var existing = GetById(entity.Id);

        if (existing is null)
        {
            return false;
        }

        var index = _students.IndexOf(existing);
        _students[index] = entity;

        return true;
    }

    public bool Delete(int id)
    {
        var student = GetById(id);

        return student is not null && _students.Remove(student);
    }
}