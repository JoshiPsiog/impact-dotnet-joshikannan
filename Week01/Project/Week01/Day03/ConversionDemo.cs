namespace Week01.Day03;

public static class ConversionDemo
{
    public static void Run()
    {
        Console.WriteLine("===== Implicit Conversion =====");

        int number = 100;
        long longNumber = number;
        float floatNumber = longNumber;
        double doubleNumber = floatNumber;

        Console.WriteLine($"int    : {number}");
        Console.WriteLine($"long   : {longNumber}");
        Console.WriteLine($"float  : {floatNumber}");
        Console.WriteLine($"double : {doubleNumber}");

        Console.WriteLine();

        Console.WriteLine("===== Explicit Conversion =====");

        double price = 99.99;
        int wholeNumber = (int)price;

        Console.WriteLine($"Original Double : {price}");
        Console.WriteLine($"Converted Int   : {wholeNumber}");

        // Explanation:
        // Explicit conversion may lose data.
        // The decimal part (.99) is removed.

        Console.WriteLine();

        Console.WriteLine("===== String Conversion =====");

        string numberText = "123";

        int convertValue = Convert.ToInt32(numberText);

        Console.WriteLine($"Convert.ToInt32 : {convertValue}");

        if (int.TryParse(numberText, out int parsedValue))
        {
            Console.WriteLine($"TryParse        : {parsedValue}");
        }

        object text = "Hello";

        Console.WriteLine($"Using 'is' : {text is string}");

        string? result = text as string;

        Console.WriteLine($"Using 'as' : {result}");

        // Explanation:
        // Convert.ToInt32() converts a valid string to an integer.
        // TryParse() safely converts without throwing exceptions.
        // 'is' checks the object's type.
        // 'as' safely converts compatible reference types.
    }
}