using System.Collections;
using System.Diagnostics;

//var text = "hello there";
//foreach(char character in text)
//{
//    Console.WriteLine(character);
//}

//var customCollection = new CustomCollection(
//    new string[] { "aaa", "bbb", "ccc" });

//foreach(var word in customCollection)
//{
//    Console.WriteLine(word);
//}
//var words = new string[] { "aaa", "bbb", "ccc" };
//foreach(var word in words)
//{
//    Console.WriteLine(word);
//}
//IEnumerator wordsEnumerator = words.GetEnumerator();
//object currentWord;
//while (wordsEnumerator.MoveNext())
//{
//    currentWord = wordsEnumerator.Current;
//    Console.WriteLine(currentWord);
//}

//var customCollection = new CustomCollection(
//    new string[] { "aaa", "bbb", "ccc" });
//var enumerator = customCollection.GetEnumerator();

//foreach(var word in customCollection)
//{
//    Console.WriteLine(word);
//}

//var first = customCollection[0];
//customCollection[1] = "abc";

//var numbers = new List<int> { 1, 2, 3, 4, 5 };
//var array = new int[10];
//numbers.CopyTo(array, 2);

//var numbers = new List<int>(new int[] { 1, 2, 3 });

//var array = new int[] { 1, 2, 3 };
//var implementedInterfaces = array.GetType().GetInterfaces();

//ICollection<int> arrayAsCollection = array;
//arrayAsCollection.Add(4);

//var sortedList = new List<int>
//{
//    1, 3, 4, 5, 6, 11, 12, 14, 16, 18
//};

//var indexOf1 = sortedList.FindIndexInSorted(1);
//var indexOf11 = sortedList.FindIndexInSorted(11);
//var indexOf12 = sortedList.FindIndexInSorted(12);
//var indexOf18 = sortedList.FindIndexInSorted(18);
//var indexOf13 = sortedList.FindIndexInSorted(13);

var input = Enumerable.Range(0, 100_000_000).ToArray();

Stopwatch stopwatch = Stopwatch.StartNew(); 

// Slowest
//var list = new List<int>();
//foreach(var item in input)
//{
//    list.Add(item);
//}

//Fastest 
//var list = new List<int>(input);

// Faster than slowest and slower than fastest
var list = new List<int>(input.Length);
foreach(var item in input)
{
    list.Add(item);
}

stopwatch.Stop();
Console.WriteLine($"Took: {stopwatch.ElapsedMilliseconds} ms");

list.Clear();
list.TrimExcess();

list.AddRange(input);
list.RemoveRange(5, 10);
list.RemoveAt(7);
list.Remove(99);

Console.ReadKey();

public static class ListExtensions
{
    // Binary Search
    public static int? FindIndexInSorted<T>(
        this IList<T> list, T itemToFind)
        where T : IComparable<T>
    {
        int leftBound = 0;
        int rightBound = list.Count - 1;

        while(leftBound <= rightBound)
        {
            int middleIndex = (leftBound + rightBound) / 2;
            if (itemToFind.Equals(list[middleIndex]))
            {
                return middleIndex;
            }
            else if (itemToFind.CompareTo(list[middleIndex]) < 0)
            {
                rightBound = middleIndex - 1;
            }
            else
            {
                leftBound = middleIndex + 1;
            }
        }
        return null;
    }
}

public class CustomCollection : IEnumerable<string>
{
    public string[] Words { get; }

    public CustomCollection(string[] words)
    {
        Words = words;
    }

    public string this[int index]
    {
        get => Words[index];
        set => Words[index] = value;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<string> GetEnumerator()
    {
        return new WordsEnumerator(Words);
    }
}

public class WordsEnumerator : IEnumerator<string>
{
    private const int InitialPosition = -1;
    private int _currentPosition = InitialPosition;
    private readonly string[] _words;

    public WordsEnumerator(string[] words)
    {
        _words = words;
    }

    object IEnumerator.Current => Current;
    public string Current
    {
        get
        {
            try
            {
                return _words[_currentPosition];
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new IndexOutOfRangeException(
                    $"{nameof(CustomCollection)}'s end reached.",
                    ex);
            }
        }
    }

    public bool MoveNext()
    {
        ++_currentPosition;
        return _currentPosition < _words.Length;
    }

    public void Reset()
    {
        _currentPosition = InitialPosition;
    }

    public void Dispose()
    {

    }
}