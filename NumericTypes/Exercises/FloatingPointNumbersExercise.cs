namespace NumericTypes.Exercises
{
    public static class FloatingPointNumbersExercise
    {
        public static bool IsAverageEqualTo(
            this IEnumerable<double> input, double valueToBeChecked)
        {
            double sum = 0d;
            int count = 0;
            foreach (var item in input)
            {
                if (double.IsNaN(item) || double.IsInfinity(item))
                {
                    throw new ArgumentException("Input contains NaN or Infinity.");
                }
                sum += item;
                count += 1;
            }
            sum /= count;
            return Math.Abs(sum - valueToBeChecked) < 0.00001d;
        }
    }
}
