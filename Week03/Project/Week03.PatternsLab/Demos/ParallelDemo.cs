using System.Diagnostics;

namespace Week03.PatternsLab.Demos;

public static class ParallelDemo
{
    public static void Run()
    {
        Console.WriteLine("\n========== TASK 3.10 ==========\n");

        List<int> items = Enumerable.Range(1, 100).ToList();

        Stopwatch sw = new();

        // Sequential
        sw.Start();

        foreach (int item in items)
        {
            Thread.Sleep(100);
        }

        sw.Stop();

        Console.WriteLine($"Sequential : {sw.ElapsedMilliseconds} ms");

        // Task.Run
        sw.Restart();

        List<Task> tasks = new();

        foreach (int item in items)
        {
            tasks.Add(Task.Run(() =>
            {
                Thread.Sleep(100);
            }));
        }

        Task.WaitAll(tasks.ToArray());

        sw.Stop();

        Console.WriteLine($"Task.Run : {sw.ElapsedMilliseconds} ms");

        // Parallel
        sw.Restart();

        Parallel.ForEach(items, item =>
        {
            Thread.Sleep(100);
        });

        sw.Stop();

        Console.WriteLine($"Parallel.ForEach : {sw.ElapsedMilliseconds} ms");
    }
}