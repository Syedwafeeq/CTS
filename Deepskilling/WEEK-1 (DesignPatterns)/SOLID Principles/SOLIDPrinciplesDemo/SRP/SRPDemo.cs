namespace SOLIDPrinciplesDemo.SRP;

public static class SRPDemo
{
    public static void Run()
    {
        var employee = new Employee(
            id: 101,
            name: "John Doe",
            department: "Engineering",
            salary: 75000m);

        var reportGenerator = new EmployeeReportGenerator();

        reportGenerator.Generate(employee);
    }
}