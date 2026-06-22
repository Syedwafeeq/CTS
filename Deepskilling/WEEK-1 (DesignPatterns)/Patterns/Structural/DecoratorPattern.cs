using System;

interface IMessage
{
    void Send();
}

class BasicMessage : IMessage
{
    public void Send()
    {
        Console.WriteLine("Sending basic message");
    }
}

abstract class MessageDecorator : IMessage
{
    protected IMessage message;

    public MessageDecorator(IMessage message)
    {
        this.message = message;
    }

    public virtual void Send()
    {
        message.Send();
    }
}

class EncryptedMessage : MessageDecorator
{
    public EncryptedMessage(IMessage message)
        : base(message)
    {
    }

    public override void Send()
    {
        base.Send();
        Console.WriteLine("Applying encryption");
    }
}

class DecoratorPattern
{
    static void Main()
    {
        IMessage message = new BasicMessage();

        IMessage encrypted =
            new EncryptedMessage(message);

        encrypted.Send();
    }
}
