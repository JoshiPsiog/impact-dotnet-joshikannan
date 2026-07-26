using Week03.PatternsLab.Utilities;

namespace Week03.PatternsLab.Demos;

public static class DisposeDemo
{
    public static void Run()
    {
        Console.WriteLine("\n========== TASK 3.2 ==========\n");

        string path;

        using (TempFileManager manager = new())
        {
            path = manager.FilePath;

            Console.WriteLine($"Inside using : {File.Exists(path)}");
        }

        Console.WriteLine($"Outside using : {File.Exists(path)}");
    }
}