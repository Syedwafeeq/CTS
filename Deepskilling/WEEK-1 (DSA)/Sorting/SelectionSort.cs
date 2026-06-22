using System;

class SelectionSort
{
    static void Main()
    {
        int[] numbers = { 29, 10, 14, 37, 13 };

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = numbers[i];
            numbers[i] = numbers[minIndex];
            numbers[minIndex] = temp;
        }

        Console.WriteLine("Sorted Array:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
