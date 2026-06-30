namespace Week01.Day03;

public static class MemoryModelDemo
{
    public static void Run()
    {
        Console.WriteLine("===== Value Type : int =====");

        int number1 = 10;
        int number2 = number1;

        number2 = 20;

        Console.WriteLine($"number1 = {number1}");
        Console.WriteLine($"number2 = {number2}");

        // Explanation:
        // int is a Value Type.
        // Assigning number1 to number2 creates a separate copy.
        // Modifying number2 does not affect number1.

        Console.WriteLine("===== Reference Type : Array =====");

        int[] numbers1 = { 10, 20, 30 };
        int[] numbers2 = numbers1;

        numbers2[0] = 100;

        Console.WriteLine($"numbers1[0] = {numbers1[0]}");
        Console.WriteLine($"numbers2[0] = {numbers2[0]}");

        // Explanation:
        // Arrays are Reference Types.
        // Assigning numbers1 to numbers2 copies the reference, not the array.
        // Both variables point to the same array in memory.
        // Modifying numbers2 also changes numbers1.

        Console.WriteLine("\n===== Struct (Value Type) =====");

        CoordinateStruct point1 = new CoordinateStruct
        {
            X = 10,
            Y = 20
        };

        CoordinateStruct point2 = point1;

        point2.X = 100;

        Console.WriteLine($"point1.X = {point1.X}");
        Console.WriteLine($"point2.X = {point2.X}");

        // Explanation:
        // CoordinateStruct is a Value Type.
        // Assigning point1 to point2 creates a separate copy.
        // Changing point2 does NOT affect point1.

        Console.WriteLine("\n===== Class (Reference Type) =====");

        CoordinateClass coordinate1 = new CoordinateClass
        {
            X = 10,
            Y = 20
        };

        CoordinateClass coordinate2 = coordinate1;

        coordinate2.X = 100;

        Console.WriteLine($"coordinate1.X = {coordinate1.X}");
        Console.WriteLine($"coordinate2.X = {coordinate2.X}");

        // Explanation:
        // CoordinateClass is a Reference Type.
        // Assigning coordinate1 to coordinate2 copies only the reference.
        // Both variables point to the same object.
        // Changing coordinate2 also changes coordinate1.
    }
}
