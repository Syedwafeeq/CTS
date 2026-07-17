namespace StringHelperTests;

public class StringHelper
{
    public string Reverse(string input)
    {
        char[] chars = input.ToCharArray();
        System.Array.Reverse(chars);
        return new string(chars);
    }

    public bool IsPalindrome(string input)
    {
        return input == Reverse(input);
    }

    public string ToUpperCase(string input)
    {
        return input.ToUpper();
    }
}
