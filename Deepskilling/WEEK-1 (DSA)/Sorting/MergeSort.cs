using System;

class MergeSort
{
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
        {
            leftArray[i] = arr[left + i];
        }

        for (int j = 0; j < n2; j++)
        {
            rightArray[j] = arr[mid + 1 + j];
        }

        int a = 0;
        int b = 0;
        int k = left;

        while (a < n1 && b < n2)
        {
            if (leftArray[a] <= rightArray[b])
            {
                arr[k] = leftArray[a];
                a++;
            }
            else
            {
                arr[k] = rightArray[b];
                b++;
            }

            k++;
        }

        while (a < n1)
        {
            arr[k] = leftArray[a];
            a++;
            k++;
        }

        while (b < n2)
        {
            arr[k] = rightArray[b];
            b++;
            k++;
        }
    }

    static void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            Sort(arr, left, mid);
            Sort(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }
    }

    static void Main()
    {
        int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };

        Sort(numbers, 0, numbers.Length - 1);

        Console.WriteLine("Sorted Array:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
