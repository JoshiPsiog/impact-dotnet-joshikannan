using Week04_MVC_Pattern.Models;

namespace Week04_MVC_Pattern.Services;

public interface IStudentService
{
    bool AddStudent(Student student);

    IEnumerable<Student> GetAll();

    Student? GetById(int id);

    bool UpdateStudent(Student student);

    bool DeleteStudent(int id);

    IEnumerable<string> GetTransactionLog();
}