// Integers are value types => value semantics
//int number = 5;
//int anotherNumber = number; // copies the value
//anotherNumber++;

//Console.WriteLine("Number is " + number);
//Console.WriteLine("anotherNumber is " + anotherNumber);

// Classes have reference semantics
using System.Collections;

var john = new Person { Name = "John", Age = 34 };
/*var person = john;*/ // copies the reference
//person.Age = 32;


//Console.WriteLine("John's age is " + john.Age);
//Console.WriteLine("person's age is " + person.Age + "\n");

//AddOneToNumber(number);
//AddOneToPersonAge(john);

//Console.WriteLine("Number now is " + number);
//Console.WriteLine("John's age now is " + john.Age);

//var olderJohn = AddOneToPersonsAge(john);
//Console.WriteLine("John's age is " + john.Age);
//Console.WriteLine("Older John's age is " + olderJohn.Age);

//AddOneToNumber(ref number);

//Console.WriteLine("\nNumber now is " + number);

//MethodWithOutParameter(out int otherNumber);
//Console.WriteLine("\nother number is " + otherNumber);

//var list = new List<int> { 1, 2, 3 };
//AddOneToList(ref list);
//Console.WriteLine(string.Join(", ", list));
int number = 5;
//var person = new Person { Name = "Ted", Age = 19 };
// number is boxed; wrapped inside a new instance of a 
// System.Objec class and stored on the heap
object boxedNumber = number;

// Unboxing must be done explicitly
//short unboxedNumber = (short)number;
int unboxedNumber = (int)number;


// Interfaces are reference types
// so boxing will be performed
//IComparable<int> intAsComparable = number;

//var numbers1 = new List<int> { 1, 2, 3, 4, 5 };
//var numbers2 = new ArrayList { 1, 2, 3, 4, 5 };

//var numbers3 = new List<IComparable<int>> { 1, 2, 3, 4, 5 };

//var variousObjects = new List<object>
//{
//    1,
//    1.5m,
//    new DateTime(2024, 6, 1),
//    "hello",
//    new Person {Name = "Anna", Age = 61 }
//};

//foreach(object someObject in variousObjects)
//{
//    Console.WriteLine(
//        someObject.GetType().Name);
//}
//string userInput = Console.ReadLine();
//if (userInput == "Print person")
//{
//    Person person = new Person() { Name = "Shivay", Age = 37 };
//    Console.WriteLine($"{person.Name} is {person.Age} years old.");
//}
// Should not be used in production
// For debugging memory consumption
//GC.Collect();

//bool flag = true;
//Person person = new Person();
//if (flag)
//{
//    string textinsideif = "aaa";
//    person.Name = "tom";
//}
//string text = "bbb";

//bool someCondition = true;

//if (someCondition)
//{
//    var someClassInstance = new SomeClass();
//}

//Console.WriteLine(
//    "Count of all instances is now " + SomeClass.CountOfInstances);

//for(var i = 0; i < 5; ++i)
//{
//    var person = new Person { Name = "Shivay", Age = 37 };
//}

//GC.Collect();
//Console.WriteLine("Ready to close.");
const string filePath = "file.txt";
// Syntactic sugar. Equivalent to try finally block
using (var writer = new FileWriter(filePath))
{
    writer.Write("some Text");
    writer.Write("Some other text");
}


using var reader = new SpecificLineFromTextFileReader(filePath);
var third = reader.ReadLineNumber(3);
var fourth = reader.ReadLineNumber(4);
reader.Dispose();

Console.WriteLine("Third line is: " + third);
Console.WriteLine("Fourth line is: " + fourth);


Console.WriteLine("Press any key to close.");
Console.ReadKey();

void AddOneToList(ref List<int> numbers)
{
    //numbers.Add(1); // ref not needed
    numbers = null;
}

void MethodWithOutParameter(out int number)
{
    number = 10;
}

void AddOneToNumber(ref int number)
{
    ++number;
}

//void AddOneToPersonAge(Person person)
//{
//    ++person.Age;
//}

Person AddOneToPersonsAge(Person person)
{
    return new Person { Name = person.Name, Age = person.Age + 1 };
}
public class FileWriter : IDisposable
{
    private readonly StreamWriter _streamWriter;
    public FileWriter(string filePath)
    {
        _streamWriter = new StreamWriter(filePath, true);
    }


    public void Write(string text)
    {
        _streamWriter.WriteLine(text);
        _streamWriter.Flush();
    }
    public void Dispose()
    {
        _streamWriter.Dispose();
    }
    
}
public class SpecificLineFromTextFileReader : IDisposable
{
    private readonly StreamReader _streamReader;
    public SpecificLineFromTextFileReader(string filePath)
    {
        _streamReader = new StreamReader(filePath);
    }


    public string ReadLineNumber(int lineNumber)
    {
        _streamReader.DiscardBufferedData();
        _streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
        for (var i = 0; i < lineNumber - 1; ++i)
        {
            _streamReader.ReadLine();
        }
        return _streamReader.ReadLine();
    }
    public void Dispose()
    {
        _streamReader.Dispose();
    }
}
class Person
{
    public string Name { get; init; }
    public int Age { get; init; }

    ~Person()
    {
        Console.WriteLine($"Person named {Name} is being destructed.");
    }
    //protected override void Finalize()
    //{
    //    Console.WriteLine($"Person named {Name} is being destructed.");
    //}
}

// structs are value types
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class SomeClass
{
    private static List<SomeClass> _allExistingInstances =
        new List<SomeClass>();
    public static int CountOfInstances => _allExistingInstances.Count;
    public SomeClass()
    {
        _allExistingInstances.Add(this);
    }
}