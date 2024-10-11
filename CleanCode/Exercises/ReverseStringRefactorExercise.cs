namespace CleanCode.Exercises
{
    public class ReverseStringRefactorExercise
    {
        public static string Reverse_Refactored(string input)
        {
            var resultCharacters = new char[input.Length];
            int currentIndex = input.Length - 1;

            foreach (var character in input)
            {
                resultCharacters[currentIndex] = character;
                --currentIndex;
            }

            return new string(resultCharacters);

        }

        //do not modify this method!
        public static string Reverse(string str)
        {
            var arr = new char[str.Length];

            var i = str.Length - 1;
            foreach (var _char in str)
            {
                arr[i] = _char;
                --i;
            }

            return new string(arr);
        }
    }
}

