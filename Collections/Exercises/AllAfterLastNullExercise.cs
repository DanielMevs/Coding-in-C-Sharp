namespace Collections.Exercises
{
    public class AllAfterLastNullExercise
    {
        public static IEnumerable<T> GetAllAfterLastNullReversed<T>(IList<T> input)
        {
            foreach (var item in input.AsEnumerable().Reverse())
            {
                if (item != null)
                {
                    yield return item;
                }
                else
                {
                    yield break;
                }
            }
        }
    }
}
