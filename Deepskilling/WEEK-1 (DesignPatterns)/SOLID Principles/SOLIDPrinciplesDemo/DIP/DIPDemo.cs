namespace SOLIDPrinciplesDemo.DIP;

public static class DIPDemo
{
    public static void Run()
    {
        ILogger logger = new ConsoleLogger();

        var employeeService = new EmployeeService(logger);

        employeeService.AddEmployee("Alice");
    }
}