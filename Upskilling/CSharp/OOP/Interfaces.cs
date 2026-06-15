using System;

interface ILogger
{
    void Log(string message);
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}

class Interfaces
{
    static void Main()
    {
        ILogger logger = new ConsoleLogger();
        logger.Log("Application started");
    }
}
