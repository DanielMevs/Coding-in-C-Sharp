var numbers = new[] { 1, 4, 7, 19, 2 };
//Func<int, bool> predicate1 = IsLargerThan10;
//Func<int, bool> predicate2 = IsEven;

Console.WriteLine(
    "IsAnyLargerThan10? " + IsAny(numbers, n => n > 10));

//var someFunc = n  => n % 2 == 0;
Console.WriteLine(
    "IsAnyEven? " + IsAny(numbers, n => n % 2 == 0));



Func<int, DateTime, string, decimal> someFunc;
Action<string, string, bool> someAction;


Console.ReadKey();

//bool IsLargerThan10(int number)
//{
//    return number < 10;
//}

//bool IsEven(int number)
//{
//    return (number % 2 == 0);
//}

bool IsAny(
    IEnumerable<int> numbers,
    Func<int, bool> predicate)
{
    foreach(var number in numbers)
    {
        if (predicate(number))
        {
            return true;
        }
    }
    return false;
}


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