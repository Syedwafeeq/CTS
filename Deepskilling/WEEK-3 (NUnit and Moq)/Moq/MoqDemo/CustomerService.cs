public class CustomerService
{
    private readonly IEmailService emailService;

    public CustomerService(IEmailService emailService)
    {
        this.emailService = emailService;
    }

    public bool Register(string email)
    {
        return emailService.SendEmail(email);
    }
}