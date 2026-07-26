namespace Week01.Day04;

public static class TupleDemo
{
    public static void Run()
    {
        Console.WriteLine("===== Min Max Tuple =====");

        int[] numbers = { 15, 8, 30, 22, 5 };

        var (min, max) = GetMinMax(numbers);

        Console.WriteLine($"Minimum : {min}");
        Console.WriteLine($"Maximum : {max}");

        Console.WriteLine();

        Console.WriteLine("===== Employee Tuple =====");

        var (name, age, department) = GetEmployee();

        Console.WriteLine($"Name       : {name}");
        Console.WriteLine($"Age        : {age}");
        Console.WriteLine($"Department : {department}");

        // Explanation:
        // Tuples allow multiple values to be returned from a method.
        // Deconstruction stores each returned value into separate variables.
    }

    public static (int Min, int Max) GetMinMax(int[] numbers)
    {
        return (numbers.Min(), numbers.Max());
    }

    public static (string Name, int Age, string Department) GetEmployee()
    {
        return ("Joshi", 24, "Software Development");
    }
}