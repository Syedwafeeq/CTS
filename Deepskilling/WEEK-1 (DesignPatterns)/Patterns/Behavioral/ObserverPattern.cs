using System;
using System.Collections.Generic;

interface ISubscriber
{
    void Update(string message);
}

class Subscriber : ISubscriber
{
    private string name;

    public Subscriber(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine(name + " received: " + message);
    }
}

class YouTubeChannel
{
    private List<ISubscriber> subscribers =
        new List<ISubscriber>();

    public void Subscribe(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void UploadVideo(string title)
    {
        Console.WriteLine("New video uploaded: " + title);

        foreach (ISubscriber subscriber in subscribers)
        {
            subscriber.Update(title);
        }
    }
}

class ObserverPattern
{
    static void Main()
    {
        YouTubeChannel channel =
            new YouTubeChannel();

        channel.Subscribe(
            new Subscriber("Wafeeq"));

        channel.Subscribe(
            new Subscriber("Usaid"));

        channel.UploadVideo(
            "Design Patterns in C-sharp");
    }
}
