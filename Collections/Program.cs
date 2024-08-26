
using System.Collections;

var text = "hello there";
foreach(char character in text)
{
    Console.WriteLine(character);
}

//var customCollection = new CustomCollection(
//    new string[] { "aaa", "bbb", "ccc" });

//foreach(var word in customCollection)
//{
//    Console.WriteLine(word);
//}
var words = new string[] { "aaa", "bbb", "ccc" };
//foreach(var word in words)
//{
//    Console.WriteLine(word);
//}

IEnumerator wordsEnumerator = words.GetEnumerator();
object currentWord;
while (wordsEnumerator.MoveNext())
{
    currentWord = wordsEnumerator.Current;
    Console.WriteLine(currentWord);
}

Console.ReadKey();

public class CustomCollection //: IEnumerable<string>
{
    public string[] Words { get; }
    public CustomCollection(string[] words)
    {
        Words = words;
    }
}