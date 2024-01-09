int[] numbers = new int[] {2, 6, 1, 6, 19 };


var sum = 0;
for(var i = 0; i < numbers.Length; ++i)
{
    sum += numbers[i];
}

Console.WriteLine($"sum of elements is {sum}");



//numbers[0] = 5;
//numbers[1] = 6;
//numbers[2] = 7;
//numbers[3] = 22;
//numbers[4] = 59;
//
//var firstFromEnd = numbers[^1];
//var secondFromEnd = numbers[^2];
//
//
//Console.WriteLine($"First from end: {firstFromEnd}");
//Console.WriteLine($"Second from the end: {secondFromEnd}");

//Console.WriteLine($"Element at index 0 is {numbers[0]}");
//Console.WriteLine($"Element at index 1 is {numbers[1]}");
//Console.WriteLine($"Element at index 2 is {numbers[2]}");



//Console.WriteLine();
//Console.WriteLine($"Element at index 0 is {numbers[0]}");
//Console.WriteLine($"Element at index 1 is {numbers[1]}");
//Console.WriteLine($"Element at index 2 is {numbers[2]}");
//
//numbers[1] = 66;
//
//Console.WriteLine();
//Console.WriteLine($"Element at index 0 is {numbers[0]}");
//Console.WriteLine($"Element at index 1 is {numbers[1]}");
//Console.WriteLine($"Element at index 2 is {numbers[2]}");

//Two Dimensional Arrays

//var letters2 = new char[,]
//{
//    {'A', 'B', 'C' },
//    {'D', 'E', 'F' },
//};

char[,] letters = new char[2, 3];

letters[0, 0] = 'a';
letters[0, 1] = 'b';
letters[0, 2] = 'c';
letters[1, 0] = 'd';
letters[1, 1] = 'e';
letters[1, 2] = 'f';

var height = letters.GetLength(0);
var width = letters.GetLength(1);
Console.WriteLine($"Height is {height}");
Console.WriteLine($"Width is {width}\n");

for (int i = 0; i < height; i++)
{
    Console.WriteLine($"i is {i}");
    for (int j = 0; j < width; j++)
    {
        Console.WriteLine($"j is {j}");
        Console.WriteLine($"element is {letters[i, j]}");
    }
}

Console.WriteLine("\n\n");

var words = new[] { "and", "band", "candy", "daffy", "evoke", "focus" };


foreach(var word in words)
{
    Console.WriteLine(word);
}




Console.ReadKey();


class Exercise
{
    bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
    {
        for (var i = 0; i < words.Length; i++)
        {
            if (words[i] == wordToBeChecked)
            {
                return true;
            }

        }
        return false;
    }
}

class Exercise2
{
    int FindMax(int[,] numbers)
    {
        var height = numbers.GetLength(0);
        var width = numbers.GetLength(1);
        if (height == 0 || width == 0)
        {
            return -1;
        }
        var resultMax = numbers[0, 0];

        for (var i = 0; i < height; i++)
        {
            for (var j = 0; j < width; j++)
            {
               if (numbers[i, j] > resultMax)
                {
                    resultMax = numbers[i, j];
                }
            }
        }

        return resultMax;
    }

}
class Exercise3
{
    bool IsAnyWordLongerThan(int length, string[] words)
    {
        foreach (var word in words)
        {
            if (word.Length > length)
            {
                return true;
            }
        }
        return false;
    }
}