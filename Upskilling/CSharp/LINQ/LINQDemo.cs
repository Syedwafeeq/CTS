using System;
using System.Linq;

class LINQDemo
{
    static void Main()
    {
        int[] numbers = { 10, 25, 30, 45, 50 };

        var filtered =
            numbers.Where(n => n > 25)
                   .OrderBy(n => n)
                   .Select(n => n);

        foreach (var number in filtered)
        {
            Console.WriteLine(number);
        }
    }
}
