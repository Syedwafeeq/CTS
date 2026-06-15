using System;
using System.Threading;

class MultithreadingDemo
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Thread: " + i);
            Thread.Sleep(500);
        }
    }

    static void Main()
    {
        Thread thread = new Thread(PrintNumbers);

        thread.Start();

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Main: " + i);
            Thread.Sleep(500);
        }

        thread.Join();
    }
}

