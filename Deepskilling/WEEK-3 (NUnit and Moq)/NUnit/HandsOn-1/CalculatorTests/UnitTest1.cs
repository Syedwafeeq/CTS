using NUnit.Framework;

namespace CalculatorTests;

public class UnitTest1
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Add_ShouldReturnCorrectResult()
    {
        Assert.That(calculator.Add(10, 5), Is.EqualTo(15));
    }

    [Test]
    public void Subtract_ShouldReturnCorrectResult()
    {
        Assert.That(calculator.Subtract(10, 5), Is.EqualTo(5));
    }

    [Test]
    public void Multiply_ShouldReturnCorrectResult()
    {
        Assert.That(calculator.Multiply(10, 5), Is.EqualTo(50));
    }

    [Test]
    public void Divide_ShouldReturnCorrectResult()
    {
        Assert.That(calculator.Divide(10, 5), Is.EqualTo(2));
    }

    [Test]
    public void Divide_ByZero_ShouldThrowException()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    }
}
