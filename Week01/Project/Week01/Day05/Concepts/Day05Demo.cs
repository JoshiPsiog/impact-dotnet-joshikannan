namespace Week01.Day05.Concepts;

public static class Day05Demo
{
    public static void Run()
    {
        Console.WriteLine("===== Partial Class =====");

        Employee employee = new Employee
        {
            Name = "Joshi"
        };

        employee.Display();

        Console.WriteLine();

        Console.WriteLine("===== Access Modifiers =====");

        AccessModifierDemo access = new();

        access.Display();

        Console.WriteLine();

        Console.WriteLine("===== Record =====");

        Address address1 = new("Anna Nagar", "Chennai", "600001");
        Address address2 = new("Anna Nagar", "Chennai", "600001");

        Console.WriteLine($"address1 == address2 : {address1 == address2}");

        Address address3 = address1 with
        {
            City = "Coimbatore"
        };

        Console.WriteLine(address3);

        Console.WriteLine();

        Console.WriteLine("===== Indexer =====");

        Playlist playlist = new();

        Console.WriteLine($"Song 1 : {playlist[1]}");

        Console.WriteLine($"Song 10 : {playlist[10]}");

        Console.WriteLine($"Character : {playlist["BridgeCourse", 3]}");

        // Explanation:
        // Partial Class -> Split one class into multiple files.
        // Record -> Compares values instead of references.
        // 'with' -> Creates a copy with modified values.
        // Indexer -> Allows object access using [] like an array.
    }
}