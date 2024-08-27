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

IEnumerable customCollection = new CustomCollection(
    new string[] { "aaa", "bbb", "ccc" });
var enumerator = customCollection.GetEnumerator();

foreach(var word in customCollection)
{
    Console.WriteLine(word);
}

Console.ReadKey();

public class CustomCollection : IEnumerable<string>
{
    public string[] Words { get; }
    public CustomCollection(string[] words)
    {
        Words = words;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new WordsEnumerator(Words);
    }

    public IEnumerator<string> GetEnumerator()
    {
        //return new WordsEnumerator(Words);
        throw new NotImplementedException();    
    }
}

public class WordsEnumerator : IEnumerator
{
    private const int InitialPosition = -1;
    private int _currentPosition = InitialPosition;
    private readonly string[] _words;

    public WordsEnumerator(string[] words)
    {
        _words = words;
    }
    public object Current
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
}