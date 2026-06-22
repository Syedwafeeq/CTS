using System;

class BubbleSort
{
    static void Main()
    {
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Array:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
