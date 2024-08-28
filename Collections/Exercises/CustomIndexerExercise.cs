namespace Collections.Exercises
{
    public class CustomIndexerExercise<TLeft, TRight>
    {
        private readonly TLeft[] _left;
        private readonly TRight[] _right;

        public CustomIndexerExercise(
            TLeft[] left, TRight[] right)
        {
            _left = left;
            _right = right;
        }

        public (TLeft Left, TRight Right) this[int index1, int index2]
        {
            get
            {
                return (_left[index1], _right[index2]);
            }
            set
            {
                _left[index1] = value.Left;
                _right[index2] = value.Right;
            }
        }
    }
}
