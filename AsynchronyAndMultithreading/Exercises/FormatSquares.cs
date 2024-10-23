namespace AsynchronyAndMultithreading.Exercises
{
    public class FormatSquares
    {
        public static Task<string> FormatSquaredNumbersFrom1To(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Invalid argument: n must be greater than 0.");
            }

            Task<string> taskContinuation =
                Task.Run(() => {
                    return Enumerable.Range(1, n).
                        Select(number => number * number);
                }).ContinueWith(resultingSquares => {
                    return String.Join(",", resultingSquares.Result
                        .Select(number => number.ToString()));
                });

            return taskContinuation;
        }
    }
}
