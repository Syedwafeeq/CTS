namespace SOLIDPrinciplesDemo.DIP;

public class EmployeeService
{
    private readonly ILogger _logger;

    public EmployeeService(ILogger logger)
    {
        _logger = logger;
    }

    public void AddEmployee(string name)
    {
        _logger.Log($"Employee '{name}' added successfully.");
    }
}