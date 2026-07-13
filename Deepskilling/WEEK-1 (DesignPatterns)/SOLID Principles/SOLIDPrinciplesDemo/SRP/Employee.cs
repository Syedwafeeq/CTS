namespace SOLIDPrinciplesDemo.SRP;

public class Employee
{
    public int Id { get; }
    public string Name { get; }
    public string Department { get; }
    public decimal Salary { get; }

    public Employee(int id, string name, string department, decimal salary)
    {
        Id = id;
        Name = name;
        Department = department;
        Salary = salary;
    }
}