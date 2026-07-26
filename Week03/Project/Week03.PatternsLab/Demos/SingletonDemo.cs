using Week03.PatternsLab.Utilities;

namespace Week03.PatternsLab.Demos;

public static class SingletonDemo
{
    public static async Task Run()
    {
        Console.WriteLine("\n========== TASK 3.4 ==========\n");

        Console.WriteLine("Using Threads\n");

        List<Thread> threads = new();

        for (int i = 1; i <= 5; i++)
        {
            int id = i;

            Thread thread = new(() =>
            {
                Logger.Instance.Log($"Thread {id}");
            });

            threads.Add(thread);
            thread.Start();
        }

        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine("\nUsing Tasks\n");

        List<Task> tasks = new();

        for (int i = 1; i <= 5; i++)
        {
            int id = i;

            tasks.Add(Task.Run(() =>
            {
                Logger.Instance.Log($"Task {id}");
            }));
        }

        await Task.WhenAll(tasks);
    }
}