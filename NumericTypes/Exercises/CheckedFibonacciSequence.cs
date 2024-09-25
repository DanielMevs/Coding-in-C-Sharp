namespace NumericTypes.Exercises
{
    public class CheckedFibonacciSequence
    {
        public static class CheckedFibonacciExercise
        {
            public static IEnumerable<int> GetFibonacci(int n)
            {
                checked
                {
                    int first = -1;
                    int second = 1;

                    for (int i = 0; i < n; i++)
                    {
                        int sum = first + second;
                        yield return sum;
                        first = second;
                        second = sum;
                    }
                    
                }
            }
        }
    }
}
