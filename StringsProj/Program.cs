﻿// Chars
using System.Diagnostics;
using System.Text;

//char letter = 'a';
//char digit = '4';
//char symbol = '!';
//char newLine = '\n';

//var isUppercase = char.IsUpper(letter);
//var isLetter = char.IsLetter(letter);
//var isDigit = char.IsDigit(letter);
//var isWhitespace = char.IsWhiteSpace(letter);
//var aToUpper = char.ToUpper(letter);

//char someChar = (char)100;
//int asInt = (int)'t';

//for (char c = 'A'; c <= 'z'; c++)
//{
//    Console.WriteLine(c + ", ");
//}

//Console.OutputEncoding = Encoding.Unicode;

//var currentEncoding = Console.OutputEncoding;


//char omega = 'Ω';
//Console.WriteLine(omega);
//Console.WriteLine((int)omega);

//char dal = 'د';
//Console.WriteLine(dal);
//Console.WriteLine((int)dal);

//string text = "abc";
//text += "d";

//var upperCase = text.ToUpper();
//Console.WriteLine(text);
//Console.WriteLine(upperCase);

//string text1 = "abc";
//string text2 = "abc";
//Console.WriteLine(text1.Equals(text2));

//Modify(text);
//Console.WriteLine(text1);

//var test = new TestStruct
//{
//    Text = "abc"
//};

//var other = test;

//var other = new TestStruct
//{
//    List = test.List
//};

//const int Count = 200_000;

//var text = string.Empty;
//Stopwatch stopwatch = Stopwatch.StartNew();
//for(int i = 0; i < Count; i++)
//{
//    text += "a";
//}
//stopwatch.Stop();
//Console.WriteLine(
//    $"Concatenation took {stopwatch.ElapsedMilliseconds} ms");

//stopwatch.Restart();
//var stringBuilder = new StringBuilder();

//for(int i = 0;i < Count; i++)
//{
//    stringBuilder.Append("a");
//}
//var text2 = stringBuilder.ToString();
//stopwatch.Stop();
//Console.WriteLine(
//    $"Concatenation took {stopwatch.ElapsedMilliseconds} ms");

const int Count = 1000;
TestCharArraysMemoryConsumption(Count);
TestStringsMemoryConsumption(Count);

string text1 = "abc";
string text2 = "abc";

Console.WriteLine(object.ReferenceEquals(text1, text2));


Console.ReadKey();

void TestCharArraysMemoryConsumption(int count)
{
    var list = new List<char[] >(count);
    GC.Collect(2, GCCollectionMode.Default, true);
    var memoryBefore = GC.GetTotalMemory(false);
    for (int i = 0; i < count; ++i)
    {
        list.Add(new char[] {'a', 'a', 'a', 'a', 'a', 'a' });
    }
    GC.Collect(2, GCCollectionMode.Default, true);
    var memoryAfter = GC.GetTotalMemory(false);
    Console.WriteLine(
        "difference in bytes is " + (memoryAfter - memoryBefore));

}

void TestStringsMemoryConsumption(int count)
{
    var list = new List<string>(count);
    GC.Collect(2, GCCollectionMode.Default, true);
    var memoryBefore = GC.GetTotalMemory(false);
    for (int i = 0; i < count; ++i)
    {
        //list.Add($"aaaaa{i}");
        list.Add("aaaaa");
    }
    GC.Collect(2, GCCollectionMode.Default, true);
    var memoryAfter = GC.GetTotalMemory(false);
    Console.WriteLine(
        "difference in bytes is " + (memoryAfter - memoryBefore));

}


void Modify(string input)
{
    input += "xyz";
}

public struct TestStruct
{
    public string Text { get; init; }
}