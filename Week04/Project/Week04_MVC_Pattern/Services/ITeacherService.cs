using Week04_MVC_Pattern.Models;

namespace Week04_MVC_Pattern.Services;

public interface ITeacherService
{
    bool AddTeacher(Teacher teacher);

    IEnumerable<Teacher> GetAll();

    Teacher? GetById(int id);

    bool UpdateTeacher(Teacher teacher);

    bool DeleteTeacher(int id);
}