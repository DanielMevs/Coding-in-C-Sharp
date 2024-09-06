namespace Collections.Exercises
{
    public static class StackExtensions
    {
        public static bool DoesContainAny(this Stack<string> stack, params string[] words)
        {
            return words.Any(word => stack.Contains(word));
        }
    }
}
