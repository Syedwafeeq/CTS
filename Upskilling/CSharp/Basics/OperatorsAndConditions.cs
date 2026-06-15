using System;

class OperatorsAndConditions
{
    static void Main()
    {
        int marks = 85;
        int bonus = 5;

        int total = marks + bonus;

        Console.WriteLine("Total Marks: " + total);

        if (total >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (total >= 75)
        {
            Console.WriteLine("Grade: B");
        }
        else
        {
            Console.WriteLine("Grade: C");
        }

        string department = "Cyber Security";

        switch (department)
        {
            case "Cyber Security":
                Console.WriteLine("Security Domain");
                break;

            case "Computer Science":
                Console.WriteLine("Development Domain");
                break;

            default:
                Console.WriteLine("General Domain");
                break;
        }
    }
}
