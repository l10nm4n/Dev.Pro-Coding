using System;
using System.IO;

public static class Logger
{
    public static void LogMessage(string filePath, string message, string loginLog)
    {
        string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{loginLog.ToUpper()}] {message}";
        string logConsole = $"log_message(\"\"application.log\"\", \"\"{message}\"\", \"\"{loginLog.ToUpper()}\"\")";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(logEntry);
                Console.WriteLine(logConsole);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error writing to log file");
        }
    }
}

public class Program
{
    public static void Main()
    {
        string logFilePath = "application.log";

        Logger.LogMessage(logFilePath, "User logged in", "INFO");
        Logger.LogMessage(logFilePath, "Failed login attempt", "WARNING");
    }
}
