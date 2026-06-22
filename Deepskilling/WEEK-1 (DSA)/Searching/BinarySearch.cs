using System;

class BinarySearch
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80 };
        int target = 50;

        int left = 0;
        int right = numbers.Length - 1;
        int index = -1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (numbers[mid] == target)
            {
                index = mid;
                break;
            }
            else if (numbers[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
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
