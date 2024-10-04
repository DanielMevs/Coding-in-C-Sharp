using NUnit.Framework;
using Utilities2;
namespace UtilitiesTests;

[TestFixture]
public class EnumerableExtensionsTests
{
    [Test]
    public void SumOfEvenNumbers_ShallReturnZero_ForEmptyCollection()
    {
        var input = Enumerable.Empty<int>();
        var result = input.SumOfEvenNumbers();

        Assert.AreEqual(0, result);
    }

    [Test]
    public void SumOfEvenNumbers_ShallReturnNonZeroResult_IfEvenNumbersArePresent()
    {
        // Arrange
        var input = new int[] { 3, 1, 4, 6, 7 };

        // Act
        var result = input.SumOfEvenNumbers();

        // Assert
        var expected = 10;
        var inputAsString = string.Join(", ", input);
        Assert.AreEqual(10, result, $"For input {inputAsString} " +
            $"the result shall be {expected} but it was {result}.");
    }

    [TestCase(8)]
    [TestCase(-8)]
    [TestCase(6)]
    [TestCase(0)]
    public void SumOfEvenNumbers_ShallReturnValueOfTheOnlyItem_IfItIsEven(int number)
    {
        // Arrange
        var input = new int[] { number };

        // Act
        var result = input.SumOfEvenNumbers();

        // Assert

        Assert.AreEqual(number, result);
    }

    [TestCase(1, 2, 3)]
    [TestCase(1, -1, 0)]
    [TestCase(0, 0, 0)]
    [TestCase(100, -50, 50)]
    [TestCase(11, 12, 23)]
    public void Sum_ShallGive3_WhenAdding_1_And_2(
        int a, int b, int expected)
    {
        var result = Calculator.Sum(a, b);
        Assert.AreEqual(expected, result,
            $"Adding {a} to {b} shall give {expected}, " +
            $"but the result was {result}.");
    }
}

public static class Calculator
{
    public static int Sum(int a, int b) => a + b;
}