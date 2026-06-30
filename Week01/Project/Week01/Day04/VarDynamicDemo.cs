namespace Week01.Day04;

public static class VarDynamicDemo
{
    public static void Run()
    {
        Console.WriteLine("===== var Keyword =====");

        var number = 10;

        Console.WriteLine($"Value : {number}");
        Console.WriteLine($"Type  : {number.GetType()}");

        // Uncomment to see the compile error.
        // number = "Hello";

        // Explanation:
        // 'var' is strongly typed.
        // Once the compiler infers the type (int),
        // it cannot be changed.


        Console.WriteLine("\n===== dynamic Keyword =====");

        dynamic value = "Hello";

        Console.WriteLine($"{value} -> {value.GetType()}");

        value = 100;

        Console.WriteLine($"{value} -> {value.GetType()}");

        value = true;

        Console.WriteLine($"{value} -> {value.GetType()}");

        // Explanation:
        // 'dynamic' can change its type at runtime.


        Console.WriteLine("\n===== Dynamic Method =====");

        Console.WriteLine(Add(10, 20));

        Console.WriteLine(Add("Hello ", "World"));

        // Explanation:
        // The same method works with different types
        // because the parameter is dynamic.
    }

    public static dynamic Add(dynamic a, dynamic b)
    {
        return a + b;
    }
}