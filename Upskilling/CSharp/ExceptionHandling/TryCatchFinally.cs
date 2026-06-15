using System;

class TryCatchFinally
{
    static void Main()
    {
        try
        {
            int numerator = 10;
            int denominator = 0;

            int result = numerator / denominator;

            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
