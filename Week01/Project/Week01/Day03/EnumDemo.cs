namespace Week01.Day03;

public static class EnumDemo
{
    public static void Run()
    {
        Console.WriteLine("===== DaysOfWeek Enum =====");

        int dayNumber = 1;

        DaysOfWeek day = (DaysOfWeek)dayNumber;

        Console.WriteLine($"Day Number : {dayNumber}");
        Console.WriteLine($"Day Name   : {day}");

        // Explanation:
        // Enum maps an integer value to a meaningful name.
        // Here, 1 corresponds to Monday.

        Console.WriteLine("\n===== File Permission Enum =====");

        // Combine permissions using |
        FilePermission permissions = FilePermission.Read | FilePermission.Write;

        Console.WriteLine($"Permissions : {permissions}");

        // Check whether Write permission exists
        bool hasWritePermission = (permissions & FilePermission.Write) == FilePermission.Write;

        Console.WriteLine($"Has Write Permission : {hasWritePermission}");

        // Explanation:
        // The | operator combines multiple permissions.
        // The & operator checks whether a specific permission exists.
    }
}