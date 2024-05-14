// Integers are value types => value semantics
int number = 5;
int anotherNumber = number; // copies the value
anotherNumber++;

Console.WriteLine("Number is " + number);
Console.WriteLine("anotherNumber is " + anotherNumber);

// Classes have reference semantics
var john = new Person { Name = "John", Age = 34 };
var person = john; // copies the reference
person.Age = 32;

Console.WriteLine("John's age is " + john.Age);
Console.WriteLine("person's age is " + person.Age + "\n");

AddOneToNumber(number);
AddOneToPersonAge(john);

Console.WriteLine("Number now is " + number);
Console.WriteLine("John's age now is " + john.Age);

Console.ReadKey();

void AddOneToNumber(int number)
{
    ++number;
}

void AddOneToPersonAge(Person person)
{
    ++person.Age;
}
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
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