namespace Week01.Day04;

public static class PatternMatchingDemo
{
    public static void Run()
    {
        Console.WriteLine("===== Type Pattern =====");

        PrintValue(10);
        PrintValue("Hello");
        PrintValue(25.5);
        PrintValue(null);

        Console.WriteLine();

        Console.WriteLine("===== Switch Expression =====");

        Console.WriteLine($"95 -> Grade {CalculateGrade(95)}");
        Console.WriteLine($"82 -> Grade {CalculateGrade(82)}");
        Console.WriteLine($"74 -> Grade {CalculateGrade(74)}");
        Console.WriteLine($"60 -> Grade {CalculateGrade(60)}");

        Console.WriteLine();

        Console.WriteLine("===== Property Pattern =====");

        Order order = new Order
        {
            Status = "Completed",
            Amount = 1500
        };

        Console.WriteLine($"Discount : {GetDiscount(order)}%");
    }

    // ----------------------------------------------------
    // Type Pattern
    // ----------------------------------------------------

    public static void PrintValue(object? value)
    {
        if (value is int)
            Console.WriteLine("Integer");

        else if (value is string)
            Console.WriteLine("String");

        else if (value is double)
            Console.WriteLine("Double");

        else if (value is null)
            Console.WriteLine("Null");
    }

    // ----------------------------------------------------
    // Switch Expression
    // ----------------------------------------------------

    public static string CalculateGrade(int mark) =>
        mark switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            _ => "Fail"
        };

    // ----------------------------------------------------
    // Property Pattern
    // ----------------------------------------------------

    public static int GetDiscount(Order order) =>
        order switch
        {
            { Status: "Completed", Amount: >= 1000 } => 20,
            { Status: "Completed" } => 10,
            _ => 0
        };
}