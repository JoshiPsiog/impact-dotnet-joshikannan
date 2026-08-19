namespace Week04_MVC_Pattern.Models;

public class Student
{
    private int _age;

    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Age
    {
        get => _age;
        set
        {
            if (value < 5 || value > 100)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(Age),
                    "Age must be between 5 and 100.");
            }

            _age = value;
        }
    }

    public string RollNumber { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;
}