using System;

class InsertionSort
{
    static void Main()
    {
        int[] numbers = { 12, 11, 13, 5, 6 };

        for (int i = 1; i < numbers.Length; i++)
        {
            int key = numbers[i];
            int j = i - 1;

            while (j >= 0 && numbers[j] > key)
            {
                numbers[j + 1] = numbers[j];
                j--;
            }

            numbers[j + 1] = key;
        }

        Console.WriteLine("Sorted Array:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
