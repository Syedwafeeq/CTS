using System;

class InvalidAgeException : Exception
{
    public InvalidAgeException(string message)
        : base(message)
    {
    }
}

class CustomException
{
    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException(
                "Age must be 18 or above."
            );
        }

        Console.WriteLine("Eligible.");
    }

    static void Main()
    {
        try
        {
            ValidateAge(16);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
