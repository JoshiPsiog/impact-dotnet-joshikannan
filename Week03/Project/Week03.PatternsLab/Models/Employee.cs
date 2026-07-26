namespace Week03.PatternsLab.Models;

public class Employee : IComparable<Employee>
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public decimal Salary { get; set; }

    public int CompareTo(Employee? other)
    {
        return Salary.CompareTo(other!.Salary);
    }
}