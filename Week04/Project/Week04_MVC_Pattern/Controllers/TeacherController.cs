using Week04_MVC_Pattern.Services;
using Week04_MVC_Pattern.Views;

namespace Week04_MVC_Pattern.Controllers;

public class TeacherController
{
    private readonly ITeacherService _service;
    private readonly TeacherView _view;

    public TeacherController(
        ITeacherService service,
        TeacherView view)
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
                    AddTeacher();
                    break;

                case "2":
                    _view.PrintTeachers(_service.GetAll());
                    break;

                case "3":
                    UpdateTeacher();
                    break;

                case "4":
                    DeleteTeacher();
                    break;

                case "0":
                    running = false;
                    break;

                default:
                    _view.ShowMessage("Invalid choice.");
                    break;
            }
        }
    }

    private void AddTeacher()
    {
        var teacher = _view.PromptForTeacher();

        bool result = _service.AddTeacher(teacher);

        _view.ShowMessage(
            result
                ? "Teacher added successfully."
                : "Failed to add teacher.");
    }

    private void UpdateTeacher()
    {
        var teacher = _view.PromptForTeacher();

        bool result = _service.UpdateTeacher(teacher);

        _view.ShowMessage(
            result
                ? "Teacher updated successfully."
                : "Failed to update teacher.");
    }

    private void DeleteTeacher()
    {
        int id = _view.PromptForId();

        bool result = _service.DeleteTeacher(id);

        _view.ShowMessage(
            result
                ? "Teacher deleted successfully."
                : "Teacher not found.");
    }
}