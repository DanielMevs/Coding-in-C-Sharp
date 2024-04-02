namespace Generics.Exercises
{
    public static class TupleSwapExercise
    {
        public static Tuple<T2, T1> SwapTupleItems<T1, T2>(Tuple<T1, T2> input)
        {
            return new Tuple<T2, T1>(input.Item2, input.Item1);
        }
    }
}
