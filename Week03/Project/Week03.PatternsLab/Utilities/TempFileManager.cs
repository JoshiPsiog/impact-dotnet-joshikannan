namespace Week03.PatternsLab.Utilities;

public class TempFileManager : IDisposable
{
    public string FilePath { get; }

    private bool disposed = false;

    public TempFileManager()
    {
        FilePath = Path.Combine(Path.GetTempPath(), $"Temp_{Guid.NewGuid()}.txt");

        File.WriteAllText(FilePath, "Temporary File Created");

        Console.WriteLine($"File Created : {FilePath}");
    }

    public void Dispose()
    {
        Dispose(true);

        // Object already cleaned manually.
        // No need for Finalizer.
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);

                Console.WriteLine("Temporary File Deleted");
            }

            disposed = true;
        }
    }

    ~TempFileManager()
    {
        Dispose(false);

        Console.WriteLine("Finalizer Executed");
    }
}