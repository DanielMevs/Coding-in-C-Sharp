namespace AsynchronyAndMultithreading.Exercises
{
    public class Continuations
    {
        public static Task Test(string? input)
        {
            var task = Task.Run(() => ParseToIntAndPrint(input))
                .ContinueWith(faultedTask =>
                {
                    if (faultedTask.IsFaulted && faultedTask.Exception != null)
                    {
                        faultedTask.Exception.Handle(ex =>
                        {
                            if (ex is ArgumentNullException)
                            {
                                Console.WriteLine("The input is null.");
                                return true; // Exception handled
                            }
                            if (ex is FormatException)
                            {
                                Console.WriteLine("The input is not in a correct format.");
                                return true; // Exception handled
                            }
                            if (ex is ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Unexpected exception type.");
                                return false; // Exception not handled, task remains faulted
                            }
                            return false; // Any other exception, task remains faulted
                        });
                    }
                }, TaskContinuationOptions.OnlyOnFaulted);

            return task;
        }

        private static void ParseToIntAndPrint(string? input)
        {
            if (input is null)
            {
                throw new ArgumentNullException();
            }
            if (long.TryParse(input, out long result))
            {
                if (result > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("The number is too big for an int.");
                }
                Console.WriteLine("Parsing successful, the result is: " + result);
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
