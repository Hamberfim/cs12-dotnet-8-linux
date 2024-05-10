using CalculatorLib;

namespace CalculatorLibUnitTests;

public class CalculatorUnitTests
{
    [Fact]
    public void TestAdding2And2()
    {
        // arrange - set up inputs
        double num1 = 2;
        double num2 = 2;
        double expected = 4;
        Calculator calculator = new Calculator();

        // act - execute the function
        double actual = calculator.Add(num1, num2);

        // assert - compare the expected and actual results
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestSubtracting2And2()
    {
        // arrange - set up inputs
        double num1 = 2;
        double num2 = 2;
        double expected = 0;
        Calculator calculator = new Calculator();

        // act - execute the function
        double actual = calculator.Subtract(num1, num2);

        // assert - compare the expected and actual results
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestMultiplying2And2()
    {
        // arrange - set up inputs
        double num1 = 2;
        double num2 = 2;
        double expected = 4;
        Calculator calculator = new Calculator();

        // act - execute the function
        double actual = calculator.Multiply(num1, num2);

        // assert - compare the expected and actual results
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestDividing2And2()
    {
        // arrange - set up inputs
        double num1 = 2;
        double num2 = 2;
        double expected = 1;
        Calculator calculator = new Calculator();

        // act - execute the function
        double actual = calculator.Division(num1, num2);

        // assert - compare the expected and actual results
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestDividingByZeroReturnsNegativeOne()
    {
        // arrange
        double num1 = 2;
        double num2 = 0;
        double expected = -1;
        Calculator calculator = new Calculator();

        // act
        double actual = calculator.Division(num1, num2);

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestDividingPositiveNumberByZero()
    {
        // arrange
        double num1 = 2;
        double num2 = 0;
        double expected = double.PositiveInfinity;
        Calculator calculator = new Calculator();

        // act
        double actual = calculator.Division(num1, num2);

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestDividingNegativeNumberByZero()
    {
        // arrange
        double num1 = -2;
        double num2 = 0;
        double expected = double.NegativeInfinity;
        Calculator calculator = new Calculator();

        // act
        double actual = calculator.Division(num1, num2);

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestDividingZeroByZero()
    {
        // arrange
        double num1 = 0;
        double num2 = 0;
        double expected = double.NaN;
        Calculator calculator = new Calculator();

        // act
        double actual = calculator.Division(num1, num2);

        // assert
        Assert.Equal(expected, actual);
    }
}