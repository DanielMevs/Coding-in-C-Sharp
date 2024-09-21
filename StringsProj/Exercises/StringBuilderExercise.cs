using System.Text;

namespace StringsProj.Exercises
{
    public class StringBuilderExercise
    {
        public static string Reverse(string input)
        {
            var stringBuilder = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(input[i]);
            }

            return stringBuilder.ToString();
        }
    }
}
