using System.Collections;

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

var customCollection = new CustomCollection(
    new string[] { "aaa", "bbb", "ccc" });
var enumerator = customCollection.GetEnumerator();

foreach(var word in customCollection)
{
    Console.WriteLine(word);
}

var first = customCollection[0];
customCollection[1] = "abc";

//var numbers = new List<int> { 1, 2, 3, 4, 5 };
//var array = new int[10];
//numbers.CopyTo(array, 2);

var numbers = new List<int>(new int[] { 1, 2, 3 });

//var array = new int[] { 1, 2, 3 };
//var implementedInterfaces = array.GetType().GetInterfaces();

//ICollection<int> arrayAsCollection = array;
//arrayAsCollection.Add(4);

Console.ReadKey();

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