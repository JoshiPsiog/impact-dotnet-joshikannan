using Week04_MVC_Pattern.Data;
using Week04_MVC_Pattern.Models;

namespace Week04_MVC_Pattern.Services;

public class StudentService : IStudentService
{
    private readonly IRepository<Student> _repository;

    private readonly List<string> _transactionLog = new();

    public StudentService(IRepository<Student> repository)
    {
        _repository = repository;
    }

    public bool AddStudent(Student student)
    {
        if (string.IsNullOrWhiteSpace(student.Name))
        {
            return false;
        }

        if (student.Age < 5 || student.Age > 100)
        {
            return false;
        }

        bool duplicateRollNumber = _repository
            .GetAll()
            .Any(s => s.RollNumber.Equals(
                student.RollNumber,
                StringComparison.OrdinalIgnoreCase));

        if (duplicateRollNumber)
        {
            return false;
        }

        _repository.Add(student);

        _transactionLog.Add(
            $"ADD - Student Id: {student.Id}, Name: {student.Name}");

        return true;
    }

    public IEnumerable<Student> GetAll()
    {
        return _repository.GetAll();
    }

    public Student? GetById(int id)
    {
        return _repository.GetById(id);
    }

    public bool UpdateStudent(Student student)
    {
        if (string.IsNullOrWhiteSpace(student.Name))
        {
            return false;
        }

        if (student.Age < 5 || student.Age > 100)
        {
            return false;
        }

        var existingStudent = _repository.GetById(student.Id);

        if (existingStudent is null)
        {
            return false;
        }

        bool duplicateRollNumber = _repository
            .GetAll()
            .Any(s =>
                s.Id != student.Id &&
                s.RollNumber.Equals(
                    student.RollNumber,
                    StringComparison.OrdinalIgnoreCase));

        if (duplicateRollNumber)
        {
            return false;
        }

        bool result = _repository.Update(student);

        if (result)
        {
            _transactionLog.Add(
                $"UPDATE - Student Id: {student.Id}, Name: {student.Name}");
        }

        return result;
    }

    public bool DeleteStudent(int id)
    {
        var student = _repository.GetById(id);

        if (student is null)
        {
            return false;
        }

        bool result = _repository.Delete(id);

        if (result)
        {
            _transactionLog.Add(
                $"DELETE - Student Id: {id}, Name: {student.Name}");
        }

        return result;
    }

    public IEnumerable<string> GetTransactionLog()
    {
        return _transactionLog;
    }
}