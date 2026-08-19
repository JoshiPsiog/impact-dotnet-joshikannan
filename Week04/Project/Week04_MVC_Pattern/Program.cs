using Microsoft.Extensions.DependencyInjection;
using Week04_MVC_Pattern.Controllers;
using Week04_MVC_Pattern.Data;
using Week04_MVC_Pattern.Models;
using Week04_MVC_Pattern.Services;
using Week04_MVC_Pattern.Views;

var services = new ServiceCollection();

// Student
services.AddSingleton<IRepository<Student>, InMemoryRepository<Student>>(
    _ => new InMemoryRepository<Student>(student => student.Id));

services.AddSingleton<IStudentService, StudentService>();
services.AddSingleton<StudentView>();
services.AddSingleton<StudentController>();

// Teacher
services.AddSingleton<ITeacherRepository, InMemoryTeacherRepository>();
services.AddSingleton<ITeacherService, TeacherService>();
services.AddSingleton<TeacherView>();
services.AddSingleton<TeacherController>();

var serviceProvider = services.BuildServiceProvider();

var studentController =
    serviceProvider.GetRequiredService<StudentController>();

var teacherController =
    serviceProvider.GetRequiredService<TeacherController>();

Console.WriteLine("===== Student Management Console =====");
Console.WriteLine("1. Students");
Console.WriteLine("2. Teachers");
Console.WriteLine("0. Exit");
Console.Write("Enter your choice: ");

var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        studentController.Run();
        break;

    case "2":
        teacherController.Run();
        break;

    case "0":
        Console.WriteLine("Exiting...");
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}


//using Microsoft.Extensions.DependencyInjection;
//using Week04_MVC_Pattern.Controllers;
//using Week04_MVC_Pattern.Data;
//using Week04_MVC_Pattern.Models;
//using Week04_MVC_Pattern.Services;
//using Week04_MVC_Pattern.Views;
//var services = new ServiceCollection();
//services.AddSingleton<IRepository<Student>, InMemoryRepository<Student>>(
//    _ => new InMemoryRepository<Student>(student => student.Id));
//services.AddSingleton<IStudentService, StudentService>();
//services.AddSingleton<StudentView>();
//services.AddSingleton<StudentController>();
//var serviceProvider = services.BuildServiceProvider();
//var controller = serviceProvider.GetRequiredService<StudentController>();
//controller.Run();


//using Week04_MVC_Pattern.Controllers;
//using Week04_MVC_Pattern.Data;
//using Week04_MVC_Pattern.Models;
//using Week04_MVC_Pattern.Services;
//using Week04_MVC_Pattern.Views;
//// Manual Dependency Injection
//IRepository<Student> repository =
//    new InMemoryStudentRepository();
//IStudentService service =
//    new StudentService(repository);
//var view = new StudentView();
//var controller =
//    new StudentController(service, view);
//controller.Run();



//using Week04_MVC_Pattern.Controllers;
//using Week04_MVC_Pattern.Data;
//using Week04_MVC_Pattern.Models;
//using Week04_MVC_Pattern.Services;
//using Week04_MVC_Pattern.Views;
//IRepository<Student> repository =
//    new InMemoryRepository<Student>(student => student.Id);
//IStudentService service = new StudentService(repository);
//var view = new StudentView();
//var controller = new StudentController(service, view);
//controller.Run();


//using Week04_MVC_Pattern.Views;
//var view = new StudentView();
//view.ShowMenu();


//using Week04_MVC_Pattern.Models;
//using Week04_MVC_Pattern.Data;
//RepositoryDemo.Run();


//var student = new Student
//{
//    Id = 1,
//    Name = "Arun",
//    Age = 20,
//    RollNumber = "ST001",
//    Email = "arun@example.com"
//};

//var teacher = new Teacher
//{
//    Id = 1,
//    Name = "Ravi",
//    Email = "ravi@example.com",
//    Designation = "Professor"
//};

//Console.WriteLine("=== Student ===");
//Console.WriteLine($"Id: {student.Id}");
//Console.WriteLine($"Name: {student.Name}");
//Console.WriteLine($"Age: {student.Age}");
//Console.WriteLine($"Roll Number: {student.RollNumber}");
//Console.WriteLine($"Email: {student.Email}");

//Console.WriteLine("\n=== Teacher ===");
//Console.WriteLine($"Id: {teacher.Id}");
//Console.WriteLine($"Name: {teacher.Name}");
//Console.WriteLine($"Email: {teacher.Email}");
//Console.WriteLine($"Designation: {teacher.Designation}");

//Console.WriteLine("\n=== Age Validation ===");

//try
//{
//    student.Age = 101;
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    Console.WriteLine($"Invalid age rejected: {ex.Message}");
//}