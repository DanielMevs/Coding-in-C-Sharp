namespace ExceptionAndErrorHandling.Exercises
{
    public class RethrowingExceptions
    {
        public static int GetMaxValue(List<int> numbers)
        {
            try
            {
                return numbers.Max();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("The numbers list cannot be empty.");
                throw;
            }
            catch (ArgumentNullException ex)
            {

                throw new ArgumentNullException("The numbers list cannot be null.", ex);
            }
        }
    }
}
