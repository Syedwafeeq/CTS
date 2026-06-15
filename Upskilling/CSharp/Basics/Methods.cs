using System;

class Methods
{
    static int Square(int number)
    {
        return number * number;
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.WriteLine("Square: " + Square(8));

        Console.WriteLine("Integer Sum: " + Add(10, 20));

        Console.WriteLine("Decimal Sum: " + Add(10.5, 20.7));
    }
}
