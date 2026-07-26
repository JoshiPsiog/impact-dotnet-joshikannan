namespace Week01.Day03;

public static class NullableDemo
{
    public static void Run()
    {
        Console.WriteLine("===== Nullable Types =====");

        int? age = null;

        Console.WriteLine($"Has Value : {age.HasValue}");

        age = 25;

        Console.WriteLine($"Age       : {age}");
        Console.WriteLine($"Has Value : {age.HasValue}");

        Console.WriteLine();

        Console.WriteLine("===== Null-Coalescing Operator (??) =====");

        ApplyDiscount(null);

        ApplyDiscount(10);
    }

    public static void ApplyDiscount(double? discount)
    {
        double finalDiscount = discount ?? 5;

        Console.WriteLine($"Applied Discount : {finalDiscount}%");

        // Explanation:
        // ?? returns the left value if it is not null.
        // Otherwise, it returns the default value (5%).
    }
}