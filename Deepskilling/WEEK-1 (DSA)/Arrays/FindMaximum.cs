using System;

class FindMaximum
{
    static void Main()
    {
        int[] numbers = { 25, 10, 45, 60, 30 };

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine("Maximum: " + max);
    }
}
