namespace SOLIDPrinciplesDemo.LSP;

public class ContractEmployee : Employee
{
    public ContractEmployee(string name)
        : base(name)
    {
    }

    public override decimal CalculateSalary()
    {
        return 50000m;
    }
}