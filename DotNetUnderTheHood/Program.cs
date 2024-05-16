// Integers are value types => value semantics
int number = 5;
//int anotherNumber = number; // copies the value
//anotherNumber++;

//Console.WriteLine("Number is " + number);
//Console.WriteLine("anotherNumber is " + anotherNumber);

// Classes have reference semantics
var john = new Person { Name = "John", Age = 34 };
var person = john; // copies the reference
//person.Age = 32;


//Console.WriteLine("John's age is " + john.Age);
//Console.WriteLine("person's age is " + person.Age + "\n");

//AddOneToNumber(number);
//AddOneToPersonAge(john);

//Console.WriteLine("Number now is " + number);
//Console.WriteLine("John's age now is " + john.Age);

var olderJohn = AddOneToPersonsAge(john);
Console.WriteLine("John's age is " + john.Age);
Console.WriteLine("Older John's age is " + olderJohn.Age);

AddOneToNumber(ref number);

Console.WriteLine("\nNumber now is " + number);

MethodWithOutParameter(out int otherNumber);
Console.WriteLine("\nother number is " + otherNumber);

Console.ReadKey();

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
struct Person
{
    public string Name { get; init; }
    public int Age { get; init; }
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