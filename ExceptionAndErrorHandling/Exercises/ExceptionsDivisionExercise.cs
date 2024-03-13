namespace ExceptionAndErrorHandling.Exercises
{
    public class ExceptionsDivisionExercise
    {
        public static int DivideNumbers(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch
            {
                Console.WriteLine("Division by zero.");
                return 0;

            }
            finally
            {
                Console.WriteLine("The DivideNumbers method ends.");
            }
        }
    }
}
