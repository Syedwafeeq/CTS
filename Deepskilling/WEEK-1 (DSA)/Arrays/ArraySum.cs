using System;

class ArraySum
{
    static void Main()
    {
        int[] numbers = { 5, 10, 15, 20, 25 };

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("Sum: " + sum);
    }
}
