//var numbers = new[] { 1, 4, 7, 19, 2 };
//Func<int, bool> predicate1 = IsLargerThan10;
//Func<int, bool> predicate2 = IsEven;

//Console.WriteLine(
//    "IsAnyLargerThan10? " + IsAny(numbers, n => n > 10));

//var someFunc = n  => n % 2 == 0;
//Console.WriteLine(
//    "IsAnyEven? " + IsAny(numbers, n => n % 2 == 0));



Func<int, DateTime, string, decimal> someFunc;
Action<string, string, bool> someAction;

Func<string, string> processString1 = TrimTo5Letters;
Func<string, string> processString2 = ToUpper;

Console.WriteLine(processString1("Hellooooooooooo"));
Console.WriteLine(processString2("Hellllooooooooooo"));
Console.WriteLine();
Print print1 = text => Console.WriteLine(text.ToUpper());
Print print2 = text => Console.WriteLine(text.ToLower());
Print multicast = print1 + print2;
Print print4 = text => Console.WriteLine(text.Substring(0, 3));
multicast += print4;

multicast("Crocodile");

// Funcs and actions are generic delegates
Func<string, string, int> sumLengths = SumLengths;

Console.ReadKey();

int SumLengths(string text1, string text2)
{
    return text1.Length + text2.Length;
}

string TrimTo5Letters(string input)
{
    return input.Substring(0, 5);
}

string ToUpper(string input)
{
    return input.ToUpper();
}

delegate string ProcessString(string input);
delegate void Print(string input);

//bool IsLargerThan10(int number)
//{
//    return number < 10;
//}

//bool IsEven(int number)
//{
//    return (number % 2 == 0);
//}

//bool IsAny(
//    IEnumerable<int> numbers,
//    Func<int, bool> predicate)
//{
//    foreach(var number in numbers)
//    {
//        if (predicate(number))
//        {
//            return true;
//        }
//    }
//    return false;
//}


//bool IsAnyLargerThan10(IEnumerable<int> numbers)
//{
//    foreach (var number in numbers)
//    {
//        if (number > 10)
//        {
//            return true;
//        }
//    }
//    return false;
//}
//bool IsAnyEven(IEnumerable<int> numbers)
//{
//    foreach(var number in numbers)
//    {
//        if (number % 2 == 0)
//        {
//            return true;
//        }
//    }
//    return false;
//}