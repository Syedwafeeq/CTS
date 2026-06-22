using System;

interface ITarget
{
    void Request();
}

class LegacyService
{
    public void SpecificRequest()
    {
        Console.WriteLine("Legacy service called");
    }
}

class Adapter : ITarget
{
    private LegacyService service;

    public Adapter(LegacyService service)
    {
        this.service = service;
    }

    public void Request()
    {
        service.SpecificRequest();
    }
}

class AdapterPattern
{
    static void Main()
    {
        LegacyService legacy = new LegacyService();

        ITarget adapter = new Adapter(legacy);

        adapter.Request();
    }
}
