using System;

class Person
{
    public string Name;

    public void DisplayName()
    {
        Console.WriteLine("Name: " + Name);
    }
}

class Employee : Person
{
    public string Role;

    public void DisplayRole()
    {
        Console.WriteLine("Role: " + Role);
    }
}

class Inheritance
{
    static void Main()
    {
        Employee employee = new Employee();

        employee.Name = "Jaswanth";
        employee.Role = "Software Engineer";

        employee.DisplayName();
        employee.DisplayRole();
    }
}
