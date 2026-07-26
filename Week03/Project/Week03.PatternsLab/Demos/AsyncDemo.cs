using System.Diagnostics;
using Week03.PatternsLab.Services;

namespace Week03.PatternsLab.Demos;

public static class AsyncDemo
{
    public static async Task Run()
    {
        Console.WriteLine("\n========== TASK 3.3 ==========\n");

        UserService service = new();

        Console.WriteLine("Before Await");

        string user = await service.FetchUserDataAsync(1);

        Console.WriteLine("After Await");

        Console.WriteLine(user);

        Console.WriteLine("\n----------------------------------");
        Console.WriteLine("Sequential Execution");
        Console.WriteLine("----------------------------------");

        Stopwatch stopwatch = Stopwatch.StartNew();

        await service.FetchUserDataAsync(1);
        await service.FetchUserDataAsync(2);
        await service.FetchUserDataAsync(3);

        stopwatch.Stop();

        Console.WriteLine($"Sequential Time : {stopwatch.ElapsedMilliseconds} ms");

        Console.WriteLine("\n----------------------------------");
        Console.WriteLine("Concurrent Execution");
        Console.WriteLine("----------------------------------");

        stopwatch.Restart();

        Task<string> task1 = service.FetchUserDataAsync(1);
        Task<string> task2 = service.FetchUserDataAsync(2);
        Task<string> task3 = service.FetchUserDataAsync(3);

        await Task.WhenAll(task1, task2, task3);

        stopwatch.Stop();

        Console.WriteLine($"Concurrent Time : {stopwatch.ElapsedMilliseconds} ms");
    }
}