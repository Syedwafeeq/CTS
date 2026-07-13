namespace SOLIDPrinciplesDemo.LSP;

public static class LSPDemo
{
    public static void Run()
    {
        Employee[] employees =
        {
            new PermanentEmployee("Alice"),
            new ContractEmployee("Bob")
        };

        Console.WriteLine("Employee Salary Details");
        Console.WriteLine("-----------------------");

        foreach (var employee in employees)
        {
            Console.WriteLine(
                $"{employee.Name} : {employee.CalculateSalary():C}");
        }
    }
}