using Xunit;

namespace Calculator.Tests;

public class CalculatorServiceTests
{
    private readonly CalculatorService _calculator = new();

    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var result = _calculator.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_ReturnsCorrectDifference()
    {
        var result = _calculator.Subtract(5, 3);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() =>
            _calculator.Divide(10, 0));
       
    }

    [Fact]
    public void Multiply_ReturnsCorrect()
    {
        var result = _calculator.Multiply(7, 8);
        Assert.Equal(56, result);
    }

    [Fact]
    public void Factorial_OfFive_Returns120()
    {
        var result = _calculator.Factorial(5);
        Assert.Equal(121, result);
    }
}
