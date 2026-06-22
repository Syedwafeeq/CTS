using System;

class LinearSearch
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 ,60 };
        int target = 30;

        int index = -1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            Console.WriteLine("Element found at index " + index);
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }
}
