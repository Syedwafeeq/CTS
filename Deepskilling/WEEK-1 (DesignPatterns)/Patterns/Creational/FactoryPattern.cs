using System;

interface INotification
{
    void Send();
}

class EmailNotification : INotification
{
    public void Send()
    {
        Console.WriteLine("Sending Email Notification");
    }
}

class SmsNotification : INotification
{
    public void Send()
    {
        Console.WriteLine("Sending SMS Notification");
    }
}

class NotificationFactory
{
    public static INotification CreateNotification(string type)
    {
        if (type == "Email")
        {
            return new EmailNotification();
        }

        if (type == "SMS")
        {
            return new SmsNotification();
        }

        throw new ArgumentException("Invalid notification type");
    }
}

class FactoryPattern
{
    static void Main()
    {
        INotification notification =
            NotificationFactory.CreateNotification("Email");

        notification.Send();
    }
}
