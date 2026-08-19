using Week04_MVC_Pattern.Models;

namespace Week04_MVC_Pattern.Data;

public class InMemoryTeacherRepository : ITeacherRepository
{
    private readonly List<Teacher> _teachers = new();

    public Teacher Add(Teacher teacher)
    {
        _teachers.Add(teacher);
        return teacher;
    }

    public IEnumerable<Teacher> GetAll()
    {
        return _teachers;
    }

    public Teacher? GetById(int id)
    {
        return _teachers.FirstOrDefault(t => t.Id == id);
    }

    public bool Update(Teacher teacher)
    {
        var existing = GetById(teacher.Id);

        if (existing is null)
        {
            return false;
        }

        var index = _teachers.IndexOf(existing);
        _teachers[index] = teacher;

        return true;
    }

    public bool Delete(int id)
    {
        var teacher = GetById(id);

        return teacher is not null && _teachers.Remove(teacher);
    }
}