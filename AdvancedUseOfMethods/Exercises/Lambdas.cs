namespace AdvancedUseOfMethods.Exercises
{
    public class Lambdas
    {
        public Func<string, int> GetLength = someString => someString.Length;
        public Func<int> GetRandomNumberBetween1And10 = () => new Random().Next(1, 10);
    }
}
