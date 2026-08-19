using Week04_MVC_Pattern.Data;
using Week04_MVC_Pattern.Models;

namespace Week04_MVC_Pattern.Services;

public class TeacherService : ITeacherService
{
    private readonly ITeacherRepository _repository;

    public TeacherService(ITeacherRepository repository)
    {
        _repository = repository;
    }

    public bool AddTeacher(Teacher teacher)
    {
        if (string.IsNullOrWhiteSpace(teacher.Name))
        {
            return false;
        }

        _repository.Add(teacher);
        return true;
    }

    public IEnumerable<Teacher> GetAll()
    {
        return _repository.GetAll();
    }

    public Teacher? GetById(int id)
    {
        return _repository.GetById(id);
    }

    public bool UpdateTeacher(Teacher teacher)
    {
        if (string.IsNullOrWhiteSpace(teacher.Name))
        {
            return false;
        }

        return _repository.Update(teacher);
    }

    public bool DeleteTeacher(int id)
    {
        return _repository.Delete(id);
    }
}