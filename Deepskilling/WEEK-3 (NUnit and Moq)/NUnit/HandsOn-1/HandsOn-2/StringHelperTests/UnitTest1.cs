using NUnit.Framework;

namespace StringHelperTests;

public class UnitTest1
{
    private StringHelper helper;

    [SetUp]
    public void Setup()
    {
        helper = new StringHelper();
    }

    [Test]
    public void Reverse_ShouldReturnReversedString()
    {
        Assert.That(helper.Reverse("hello"), Is.EqualTo("olleh"));
    }

    [Test]
    public void Palindrome_ShouldReturnTrue()
    {
        Assert.That(helper.IsPalindrome("madam"), Is.True);
    }

    [Test]
    public void Palindrome_ShouldReturnFalse()
    {
        Assert.That(helper.IsPalindrome("hello"), Is.False);
    }

    [Test]
    public void UpperCase_ShouldReturnUpperCaseString()
    {
        Assert.That(helper.ToUpperCase("chatgpt"), Is.EqualTo("CHATGPT"));
    }
}
