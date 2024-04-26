using System;

class Program
{
    static void Main(string[] args)
    {
        var wordsNoUpperCase = new string[]
        {
            "quick", "brown", "fox"
        };
        Console.WriteLine(IsAnyWordUpperCase(wordsNoUpperCase));
        var wordsWithUpperCase = new string[]
        {
            "quick", "brown", "FOX"
        };
        Console.WriteLine(IsAnyWordUpperCase(wordsWithUpperCase));
        Console.ReadKey();
    }
    public static bool IsAnyWordUpperCase(
        IEnumerable<string> words)
    {
        foreach (var word in words)
        {
            bool areAllUpperCase = true;
            foreach(var letter in word)
            {
                if (char.IsLower(letter))
                {
                    areAllUpperCase = false;
                }
            }
            if(areAllUpperCase)
            {
                return true;
            }
        }
        return false;
    }
}