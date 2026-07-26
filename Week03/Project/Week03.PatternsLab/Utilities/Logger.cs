namespace Week03.PatternsLab.Utilities;

public sealed class Logger
{
    private static readonly Lazy<Logger> _instance =
        new(() => new Logger());

    public static Logger Instance => _instance.Value;

    private Logger()
    {
        Console.WriteLine("Logger Instance Created");
    }

    public void Log(string message)
    {
        Console.WriteLine($"[{GetHashCode()}] {message}");
    }
}