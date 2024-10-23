namespace AsynchronyAndMultithreading.Exercises
{
    public class FormatSquaresRefactor
    {
        public static Task<string> FormatSquaredNumbersFrom1To(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Invalid argument: n must be greater than 0.");
            }

            return 
                Task.Run(() => GenerateSquaredFrom1To(n))
                .ContinueWith(resultingSquares =>
                    Format(resultingSquares.Result));
        }

        private static IEnumerable<int> GenerateSquaredFrom1To(int n)
        {
            return Enumerable.Range(1, n).Select(number => number * number);
        }

        private static string Format(IEnumerable<int> numbers)
        {
            return string.Join(", ", numbers);
        }
    }

    
}