namespace Utilities2;

public static class EnumerableExtensions
{
    public static int SumOfEvenNumbers(
        this IEnumerable<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                sum += number;
            }
        }
        return sum;
    }
}