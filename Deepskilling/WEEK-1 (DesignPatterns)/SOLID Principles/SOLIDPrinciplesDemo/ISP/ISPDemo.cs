namespace SOLIDPrinciplesDemo.ISP;

public static class ISPDemo
{
    public static void Run()
    {
        Developer developer = new();
        Intern intern = new();

        Console.WriteLine("Developer");
        developer.Work();
        developer.AttendMeeting();

        Console.WriteLine();

        Console.WriteLine("Intern");
        intern.Work();
    }
}