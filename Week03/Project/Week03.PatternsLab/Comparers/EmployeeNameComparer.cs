using Week03.PatternsLab.Models;

namespace Week03.PatternsLab.Comparers;

public class EmployeeNameComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        return string.Compare(x?.Name, y?.Name);
    }
}