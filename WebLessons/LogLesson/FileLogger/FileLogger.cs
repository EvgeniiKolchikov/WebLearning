namespace LogLesson.FileLogger;

public class FileLogger : ILogger, IDisposable
{
    private string filePath;
    private static object _lock = new object();

    public FileLogger(string path)
    {
        filePath = path;
    }
    
    public IDisposable BeginScope<TState>(TState state)
    {
        return this;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        lock (_lock)
        {
            File.AppendAllText(filePath, formatter(state,exception) + Environment.NewLine);
        }
    }

    public void Dispose()
    {
    }
}