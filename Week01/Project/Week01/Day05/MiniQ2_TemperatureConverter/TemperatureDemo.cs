namespace Week01.Day05.MiniQ2_TemperatureConverter;

public static class TemperatureDemo
{
    public static void Run()
    {
        TemperatureConverter converter = new();

        Console.WriteLine("===== Temperature Converter =====");

        Console.WriteLine($"25°C  -> {converter.Convert(25):F2} °F");

        Console.WriteLine($"77°F  -> {converter.Convert(77, true):F2} °C");

        Console.WriteLine($"300K  -> {converter.Convert(300, "K"):F2} °C");

        // Explanation:
        // Method Overloading allows the same method name
        // with different parameter lists.
    }
}