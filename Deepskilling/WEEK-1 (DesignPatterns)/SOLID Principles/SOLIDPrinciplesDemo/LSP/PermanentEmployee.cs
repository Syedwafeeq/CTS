namespace SOLIDPrinciplesDemo.LSP;

public class PermanentEmployee : Employee
{
    public PermanentEmployee(string name)
        : base(name)
    {
    }

    public override decimal CalculateSalary()
    {
        return 80000m;
    }
}