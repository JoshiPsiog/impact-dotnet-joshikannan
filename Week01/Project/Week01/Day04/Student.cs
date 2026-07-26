namespace Week01.Day04;

public class Student
{
    // ==========================================
    // const vs readonly
    // ==========================================

    public const string College = "ABC Engineering College";

    public readonly DateTime AdmissionDate;

    // ==========================================
    // Properties
    // ==========================================

    public string Name { get; set; } = string.Empty;

    private int _age;

    public int Age
    {
        get => _age;

        set
        {
            if (value >= 5 && value <= 100)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Invalid Age! Age must be between 5 and 100.");
            }
        }
    }

    // ==========================================
    // Constructors
    // ==========================================

    public Student()
    {
        AdmissionDate = DateTime.Now;
    }

    // Constructor Chaining
    public Student(string name, int age) : this()
    {
        Name = name;
        Age = age;
    }

    // ==========================================
    // Method Overloading
    // ==========================================

    public string CalculateGrade(int mark)
    {
        return mark >= 50 ? "Pass" : "Fail";
    }

    public double CalculateGrade(int total, int obtained)
    {
        return (double)obtained / total * 100;
    }
}