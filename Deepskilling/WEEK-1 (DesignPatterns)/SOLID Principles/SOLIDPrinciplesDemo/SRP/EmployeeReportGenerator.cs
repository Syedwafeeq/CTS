namespace SOLIDPrinciplesDemo.SRP;

public class EmployeeReportGenerator
{
    public void Generate(Employee employee)
    {
        Console.WriteLine("Employee Report");
        Console.WriteLine("------------------------");
        Console.WriteLine($"ID         : {employee.Id}");
        Console.WriteLine($"Name       : {employee.Name}");
        Console.WriteLine($"Department : {employee.Department}");
        Console.WriteLine($"Salary     : {employee.Salary:C}");
    }
}