﻿//var numbers = new List<int> { 1, 3, 1, 2, 41 };
//var words = new List<string> { "aaa", "bbb" };
//var dates = new List<DateTime> { new DateTime(2023, 1, 4) };

//var numbers = new SimpleList<int>();
//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);
//numbers.Add(5);

//numbers.RemoveAt(2);
//var words = new SimpleList<string>();
//words.Add("aaa");
//words.Add("ccc");
//words.Add("ddd");

//var dates = new SimpleList<DateTime>();
//dates.Add(new DateTime(2025, 1, 6));
//dates.Add(new DateTime(2025, 1, 3));
//dates.Add(new DateTime(2025, 1, 9));

using System.Diagnostics;
using System.Numerics;

//var numbers = new List<int> { 5, 3, 2, 8, 16, 7 };
//Tuple<int, int> minAndMax = GetMinAndMax(numbers);

//var twoStrings = new Tuple<string, string>("aaa", "bbb");
//var differentTypes = new Tuple<string, int>("aaa", 2);
//var threeItems = new Tuple<string, int, bool>("aaa", 2, false);

//Console.WriteLine("Smallest number is " + minAndMax.Item1);
//Console.WriteLine("Largest number is " + minAndMax.Item2);

//DateTime date = default;
//Console.WriteLine($"Date: {date}");

//ArrayList ints = new ArrayList { 2, 3, 4, 5 };

//int sum = 0;
//foreach(object number in ints){
//    sum += (int)number;
//}
//ArrayList strings = new ArrayList { "a", "b", "c" };

//ArrayList variousItems = new ArrayList { 1, false, "abc", new DateTime() };
//object[] objects = new object[] {1, false, "abc", new DateTime() };

//var ints = new List<int> { 1, 2, 3 };
//ints.AddToFront(10);
//ints.AddToFront(11);
//foreach(var i in ints)
//{

//    Console.WriteLine(i);
//}
//ints.AddToFront<int>("abc");

//var decimals = new List<decimal> { 1.1m, 0.5m, 22.5m, 12m};
//var ints = decimals.ConvertTo<decimal, int>();

//var floats = new List<float> { 1.4f, -100.01f };
//var longs = floats.ConvertTo<float, long>();

//var dates = new List<DateTime> { new DateTime(2023, 5, 1) };
//var ints2 = dates.ConvertTo<DateTime, int>();

//var points = CreateCollectionOfRandomLength<Point>(100);
//Stopwatch stopwatch = Stopwatch.StartNew();
//var dates = CreateCollectionOfRandomLength<DateTime>(0);
//stopwatch.Stop();
//Console.WriteLine($"Execution took {stopwatch.ElapsedMilliseconds} ms.");


//var numbers = new List<int> { 5, 1, 7, 2};
//numbers.Sort();

//var words = new List<string> { "ddd", "aaa", "ccc", "bbb" };
//words.Sort();


//var people = new List<Person>
//{
//    new Person {Name = "John", YearOfBirth = 1980},
//    new Person {Name = "Anna", YearOfBirth = 1815},
//    new Person {Name = "Bill", YearOfBirth = 2150},
//};
//people.Sort();

//var employees = new List<Employee>
//{
//    new Employee {Name = "John", YearOfBirth = 1980},
//    new Employee {Name = "Anna", YearOfBirth = 1815},
//    new Employee {Name = "Bill", YearOfBirth = 2150},
//};

//var validPeople = GetOnlyValid(people);
//var validEmployees = GetOnlyValid(employees);


//foreach(var employee in validEmployees)
//{
//    employee.GoToWork();

//}
//var john = new Person { Name = "John", YearOfBirth = 1980 };
//var anna = new Person { Name = "Anna", YearOfBirth = 1915 };

//PrintInOrder(10, 5);
//PrintInOrder("aaa", "bbb");
//PrintInOrder(anna, john);

Console.WriteLine($"Square of 2 is {Calculator.Square(2)}");
Console.WriteLine($"Square of 4m is {Calculator.Square(4m)}");
Console.WriteLine($"Square of 6d is {Calculator.Square(6d)}");


Console.ReadKey();

void SomeMethod<TPet, TOwner>(TPet pet, TOwner owner)
    where TPet : Pet, IComparable<TPet>
    where TOwner : new()
{

}
public class Pet { }
public class PetOwner { }

public static class Calculator
{
    public static T Square<T>(T input) where T : INumber<T>
        => input * input;
    //public static decimal Square(decimal input) => input * input;
    //public static double Square(double input) => input * input;
}

//void PrintInOrder<T>(T first, T second) where T: IComparable<T>
//{
//    if(first.CompareTo(second) > 0)
//    {
//        Console.WriteLine($"{second} {first}");
//    }
//    else
//    {
//        Console.WriteLine($"{second} {first}");
//    }
//}

//IEnumerable<TPerson> GetOnlyValid<TPerson>(IEnumerable<TPerson> persons)
//    where TPerson : Person
//{
//    var result = new List<TPerson>();

//    foreach(var person in persons)
//    {
//        if(person.YearOfBirth > 1900 &&
//            person.YearOfBirth < DateTime.Now.Year)
//        {
//            result.Add(person);
//        }
//    }
//    return result;
//}

//IEnumerable<T> CreateCollectionOfRandomLength<T>(int maxLength) where T : new()
//{
//    var length = 100000000;//new Random().Next(maxLength + 1);

//    var result = new List<T>(length);

//    for (int i = 0; i < length; ++i)
//    {
//        result.Add(new T());
//    }
    
//    return result;
//}
public class Person //: IComparable<Person>
{
    public string Name { get; init; }
    public int YearOfBirth { get; init; }

    public override string ToString() => $"{Name} bor in {YearOfBirth}";

    //public int CompareTo(Person other)
    //{
    //    if(YearOfBirth < other.YearOfBirth)
    //    {
    //        return 1;
    //    }
    //    else if (YearOfBirth > other.YearOfBirth)
    //    {
    //        return -1;
    //    }
    //    return 0;
    //}
}
public class Employee : Person
{
    public void GoToWork() => Console.WriteLine("Going to work");
}
public class Point
{
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public int X { get; }
    public int Y { get; }
}

static class ListExtensions
{
    public static List<TTarget> ConvertTo<TSource, TTarget>(
        this List<TSource> input)
    {
        var result = new List<TTarget>();

        foreach(var item in input)
        {
            TTarget itemAfterCasting = 
                (TTarget)Convert.ChangeType(item, typeof(TTarget));
            
            result.Add(itemAfterCasting);
        }
        return result;
    }
    public static void AddToFront<T>(this List<T> list, T item)
    {
        list.Insert(0, item);
    }
}

//Tuple<int, int> GetMinAndMax(IEnumerable<int> input)
//{
//    if (!input.Any())
//    {
//        throw new InvalidOperationException(
//            $"The input collection cannot be empty.");
//    }
//    int min = input.First();
//    int max = input.First();

//    foreach(var number in input)
//    {
//        if(number > max)
//        {
//            max = number;
//        }
//        if(number < min)
//        {
//            min = number;
//        }
//    }
//    return new Tuple<int, int>(min, max);
//}

//public class SimpleTuple <T1, T2>
//{
//    public SimpleTuple(T1 item1, T2 item2)
//    {
//        Item1 = item1;
//        Item2 = item2;
//    }
//    public T1 Item1 { get; }
//    public T2 Item2 { get; }

//}

//public class SimpleTuple <T1, T2, T3>
//{
//    public SimpleTuple(T1 item1, T2 item2, T3 item3)
//    {
//        Item1 = item1;
//        Item2 = item2;
//        Item3 = item3;
//    }
//    public T1 Item1 { get; }
//    public T2 Item2 { get; }
//    public T3 Item3 { get; }

//}

class SimpleList<T>
{
    private T[] _items = new T[4];
    private int _size = 0;

    public void Add(T item)
    {
        if(_size >= _items.Length)
        {
            var newItem = new T[_items.Length * 2];

            for(int i = 0; i < _items.Length; i++)
            {
                newItem[i] = _items[i];
            }
            _items = newItem;
        }
        _items[_size] = item;
        ++_size;
    }
    public void RemoveAt(int index)
    {
        if(index < 0 || index > _size)
        {
            throw new IndexOutOfRangeException(
                $"Index {index} is outside the bounds of the list.");
        }
        --_size;
        for(int i = index; i < _size; i++)
        {
            _items[i] = _items[i + 1];
        }

        _items[_size] = default;
    }

    public T GetAtIndex(int index)
    {
        if (index < 0 || index > _size)
        {
            throw new IndexOutOfRangeException(
                $"Index {index} is outside the bounds of the list.");
        }
        return _items[index];
    }
}

//class ListOfStrings
//{
//    private string[] _items = new string[4];
//    private int _size = 0;

//    public void Add(string item)
//    {
//        if (_size >= _items.Length)
//        {
//            var newItem = new string[_items.Length * 2];

//            for (int i = 0; i < _items.Length; i++)
//            {
//                newItem[i] = _items[i];
//            }
//            _items = newItem;
//        }
//        _items[_size] = item;
//        ++_size;
//    }
//    public void RemoveAt(int index)
//    {
//        if (index < 0 || index > _size)
//        {
//            throw new IndexOutOfRangeException(
//                $"Index {index} is outside the bounds of the list.");
//        }
//        --_size;
//        for (int i = index; i < _size; i++)
//        {
//            _items[i] = _items[i + 1];
//        }

//        _items[_size] = null;
//    }

//    public string GetAtIndex(int index)
//    {
//        if (index < 0 || index > _size)
//        {
//            throw new IndexOutOfRangeException(
//                $"Index {index} is outside the bounds of the list.");
//        }
//        return _items[index];
//    }
//}