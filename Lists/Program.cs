var words = new List<string>
{
    "one",
    "two",
};

Console.WriteLine($"Count of element is {words.Count}");

foreach ( var word in words)
{
    Console.WriteLine(word);
}



Console.WriteLine();
//Console.WriteLine("Removing an item");
//words.Remove("one");

// The list does nothing if the value to be removed
//  does not exist in the list.
words.Remove("twenty one");

// Similar to .extends in Python
//var moreWord = new[] { "three", "four", "five" };
//words.AddRange( moreWord );

words.AddRange(new[] { "three", "four", "five" });

Console.WriteLine($"Index of element 'four' is {words.IndexOf("four")}");
Console.WriteLine($"Index of element 'seven' is {words.IndexOf("seven")}");

words.Clear();
Console.WriteLine($"Count of elements after Clear: {words.Count}");


foreach (var word in words)
{
    Console.WriteLine(word);
}


Console.WriteLine();
var numbers = new[] { 10, -8, 2, 12, -17 };
int nonPositiveCount;
// With the out key word, the modification of the out variable
// inside the function gets applied the variable outside the
// scope of the function.
var onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount);

foreach (var positiveNumber in onlyPositive)
{
    Console.WriteLine(positiveNumber);
}

Console.WriteLine($"Count of non positive integers: {nonPositiveCount}");


Console.ReadKey();

List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
{
    countOfNonPositive = 0;
    var result = new List<int>();

    foreach (int number in numbers)
    {
        if (number > 0)
        {
            result.Add(number);
        }
        else
        {
            countOfNonPositive++;
        }
    }
    return result;
}


class Exercise
{
    List<string> GetOnlyUpperCaseWords(List<string> words)
    {
        var result = new List<string> { };
        foreach (var word in words)
        {
            var temp = "";
            foreach (var letter in word)
            {

                if (!char.IsUpper(letter))
                {
                    continue;
                }

                temp += letter.ToString();

            }
            if (temp.Length == word.Length && !result.Contains(temp))
            {
                result.Add(temp);
            }

        }

        return result;
    }
}