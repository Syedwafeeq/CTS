using System;
using System.Threading.Tasks;

class AsyncAwaitDemo
{
    static async Task Main()
    {
        Console.WriteLine("Loading data...");

        string result = await GetDataAsync();

        Console.WriteLine(result);
    }

    static async Task<string> GetDataAsync()
    {
        await Task.Delay(2000);

        return "Data loaded successfully.";
    }
}
