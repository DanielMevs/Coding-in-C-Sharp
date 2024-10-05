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

    [TestCaseSource(nameof(GetSumOfEvenNumbersTestCases))]
    public void SumOfEvenNumbers_ShallReturnNonZeroResult_IfEvenNumbersArePresent(
        IEnumerable<int> input, int expected)
    {
        // Act
        var result = input.SumOfEvenNumbers();

        // Assert
        var inputAsString = string.Join(", ", input);
        Assert.AreEqual(expected, result, $"For input {inputAsString} " +
            $"the result shall be {expected} but it was {result}.");
    }

    private static IEnumerable<object> GetSumOfEvenNumbersTestCases()
    {
        return new[]
        {
            new object[] { new int[] { 3, 1, 4, 6, 7 }, 10 },
            new object[] { new List<int> { 100, 200, 1}, 300 },
            new object[] { new List<int> { -3, -5, 0 }, 0 },
            new object[] { new List<int> { -4, -8 }, -12 },
        };
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

    [Test]
    public void SumOfEventNumbers_ShallThrowException_ForNullInput()
    {
        IEnumerable<int>? input = null;

        var exception = Assert.Throws<ArgumentNullException>(
            () => input!.SumOfEvenNumbers());
    }

    [Test]
    public void Values_ShallBeEqualOrEquivalent_ForTwoCollections()
    {
        var collection1 = new List<int> { 1, 2, 3 };
        var collection2 = new List<int> { 1, 2, 3 };
        var collection3 = new List<int> { 2, 1, 3 };

        Assert.AreEqual (collection1, collection2);
        CollectionAssert.AreEqual (collection1, collection2);
        
        // Does not check the order of the elements
        CollectionAssert.AreEquivalent(collection3, collection2);
    }
}

public static class Calculator
{
    public static int Sum(int a, int b) => a + b;
}