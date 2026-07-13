namespace SOLIDPrinciplesDemo.ISP;

public class Developer : IWork, IAttendMeeting
{
    public void Work()
    {
        Console.WriteLine("Developer is writing code.");
    }

    public void AttendMeeting()
    {
        Console.WriteLine("Developer is attending a sprint meeting.");
    }
}