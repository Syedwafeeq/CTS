using System;

class Student
{
    public int Id;
    public string Name;
    public string Department;

    public void Display()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Department: " + Department);
    }
}

class ClassesAndObjects
{
    static void Main()
    {
        Student student = new Student();

        student.Id = 101;
        student.Name = "Jaswanth";
        student.Department = "Cyber Security";

        student.Display();
    }
}
