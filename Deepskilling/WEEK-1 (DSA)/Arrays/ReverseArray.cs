using System;

class ReverseArray
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Array.Reverse(numbers);

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
