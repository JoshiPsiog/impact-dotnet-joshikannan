using Week04_MVC_Pattern.Models;

namespace Week04_MVC_Pattern.Data;

public interface ITeacherRepository
{
    Teacher Add(Teacher teacher);

    IEnumerable<Teacher> GetAll();

    Teacher? GetById(int id);

    bool Update(Teacher teacher);

    bool Delete(int id);
}