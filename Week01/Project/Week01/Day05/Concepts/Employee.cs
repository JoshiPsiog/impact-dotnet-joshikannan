namespace Week01.Day05.Concepts;

public partial class Employee
{
    public string Name { get; set; } = string.Empty;

    partial void ShowDepartment();

    public void Display()
    {
        Console.WriteLine($"Employee Name : {Name}");
        ShowDepartment();
    }
}