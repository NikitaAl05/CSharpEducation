namespace Practice4.Task2;

public enum LogLevel
{
    Trace,
    Info,
    Debug,
    Warning,
    Error,
    Fatal
}

public interface ILogger
{
    public void Log(string message, LogLevel level);
    public void Trace(string message);
    public void Info(string message);
    public void Debug(string message);
    public void Warning(string message);
    public void Error(string message);
    public void Fatal(string message);

}       

public class ConsoleLogger : ILogger
{
    public void Log(string message, LogLevel level)
    {
        string log = $"Date: {DateTime.Now} | Name: {GetType().Name} |Level: {level} | Message: {message}";
        Console.WriteLine(log);
    }
    
    public void Trace(string message) => Log(message, LogLevel.Trace);
    public void Info(string message) => Log(message, LogLevel.Info);
    public void Debug(string message) => Log(message, LogLevel.Debug);
    public void Warning(string message) => Log(message, LogLevel.Warning);
    public void Error(string message) => Log(message, LogLevel.Error);
    public void Fatal(string message) => Log(message, LogLevel.Fatal);
}

public class FileLogger : ILogger
{
    private string file;

    public FileLogger(string file)
    {
        this.file = file;
    }

    public void Log(string message, LogLevel level)
    {
        string log = $"Date: {DateTime.Now} | Name: {GetType().Name} |Level: {level} | Message: {message}";
        File.AppendAllLines(this.file, new[] { log });
    }
    
    public void Trace(string message) => Log(message, LogLevel.Trace);
    public void Info(string message) => Log(message, LogLevel.Info);
    public void Debug(string message) => Log(message, LogLevel.Debug);
    public void Warning(string message) => Log(message, LogLevel.Warning);
    public void Error(string message) => Log(message, LogLevel.Error);
    public void Fatal(string message) => Log(message, LogLevel.Fatal);
}
