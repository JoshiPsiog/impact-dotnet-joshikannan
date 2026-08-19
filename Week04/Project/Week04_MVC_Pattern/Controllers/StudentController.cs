using Week04_MVC_Pattern.Services;
using Week04_MVC_Pattern.Views;

namespace Week04_MVC_Pattern.Controllers;

public class StudentController
{
    private readonly IStudentService _service;
    private readonly StudentView _view;

    public StudentController(
        IStudentService service,
        StudentView view)
    {
        _service = service;
        _view = view;
    }

    public void Run()
    {
        bool running = true;

        while (running)
        {
            _view.ShowMenu();

            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;

                case "2":
                    ShowAllStudents();
                    break;

                case "3":
                    ShowStudentById();
                    break;

                case "4":
                    UpdateStudent();
                    break;

                case "5":
                    DeleteStudent();
                    break;
                case "6":
                    ShowTransactionLog();
                    break;

                case "0":
                    running = false;
                    _view.ShowMessage("Exiting application...");
                    break;

                default:
                    _view.ShowMessage("Invalid choice.");
                    break;
            }
        }
    }

    private void AddStudent()
    {
        try
        {
            var student = _view.PromptForStudent();

            bool success = _service.AddStudent(student);

            _view.ShowMessage(
                success
                    ? "Student added successfully."
                    : "Failed to add student.");
        }
        catch (ArgumentOutOfRangeException)
        {
            _view.ShowMessage("Invalid age. Age must be between 5 and 100.");
        }
    }

    private void ShowAllStudents()
    {
        var students = _service.GetAll();

        _view.PrintStudents(students);
    }

    private void ShowStudentById()
    {
        int id = _view.PromptForId();

        var student = _service.GetById(id);

        if (student is null)
        {
            _view.ShowMessage("Student not found.");
            return;
        }

        _view.PrintStudents(new[] { student });
    }

    private void UpdateStudent()
    {
        try
        {
            var student = _view.PromptForStudent();

            bool success = _service.UpdateStudent(student);

            _view.ShowMessage(
                success
                    ? "Student updated successfully."
                    : "Failed to update student.");
        }
        catch (ArgumentOutOfRangeException)
        {
            _view.ShowMessage("Invalid age. Age must be between 5 and 100.");
        }
    }

    private void DeleteStudent()
    {
        int id = _view.PromptForId();

        bool success = _service.DeleteStudent(id);

        _view.ShowMessage(
            success
                ? "Student deleted successfully."
                : "Student not found.");
    }
    private void ShowTransactionLog()
    {
        var transactions = _service.GetTransactionLog();

        _view.PrintTransactionLog(transactions);
    }
}