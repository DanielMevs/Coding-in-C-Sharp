//var converter = new ObjectToTextConverter();
//Console.WriteLine(converter.Convert(
//    new House("123 Maple Rd", 179.6, 2)));

//var validPerson = new Person("John", 1981);
//var invalidDog = new Dog("R");
//var validator = new Validator();

//Console.WriteLine(validator.Validate(validPerson) ?
//    "Person is valid" :
//    "Person is invalid");

//Console.WriteLine(validator.Validate(invalidDog) ?
//    "Dog is valid" :
//    "Dog is invalid");

//var point = new Point(1, 3);
//var anotherPoint = point;
//anotherPoint.Y = 100;

//Console.WriteLine($"point is {point}");
//Console.WriteLine($"anotherPoint is {anotherPoint}");

////SomeMethod(5);
//SomeMethod(new Person());
//Point nullPoint = null;
//Person nullPerson = null;
//Person person = new Person();
//var point = new Point();

var fishyStruct1 = new FishyStruct { Numbers = new List<int> { 1, 2, 3 } };
var fishyStruct2 = fishyStruct1;

fishyStruct2.Numbers.Clear();

var point = new Point(10, 20);
//var pointMoved = point with { X = 11 };
//var pointMoved = point with { X = 5, Y = 9 };
var pointMoved = point with { X = point.X + 1 };

// with expression does not work with classes
// only works with structs, records,
// record structs, anonymous types
//var person = new Person(1, "Matthieu");
//var person2 = person with { Id = 2 };

var pet = new { Name = "Hannibal", Type = "Fish" };
var asCrab = pet with { Type = "Crab" };

// move to right by 1
//point.X++;

//MoveToRightBy1Unit(point);

//var dateTime = new DateTime(2023, 6, 7);
//dateTime.Day += 7;

var dateTime = new DateTime(2023, 6, 7);
var dateWeekAfter = dateTime.AddDays(7);



//Console.WriteLine(object.ReferenceEquals(null, null));
//Console.WriteLine(object.ReferenceEquals(1, 1));
//Console.WriteLine("Are references equal? " + 
//    object.ReferenceEquals(john, theSameAsJohn));



//Console.WriteLine("1.Equals(1): " + 1.Equals(1));
//Console.WriteLine("1.Equals(2): " + 1.Equals(2));
//Console.WriteLine("1.Equals(null): " + 1.Equals(null));

//Console.WriteLine(
//    "\"abc\".Equals(\"abc\"): " + "abc".Equals("abc"));
//Console.WriteLine();

//var john = new Person(1, "John");
//var theSameAsJohn = new Person(1, "John");
//var marie = new Person(2, "Marie");
//Console.WriteLine(
//    "john.Equals(theSameAsJohn): " + john.Equals(theSameAsJohn));

//Console.WriteLine("john.Equals(marie): " + john.Equals(marie));
//Console.WriteLine("john.Equals(null): " + john.Equals(null));
//Console.WriteLine();


//var point1 = new Point(1, 5);
//var point2 = new Point(1, 5);
//Console.WriteLine("point1.Equals(point2): " + point1.Equals(point2));

//Console.WriteLine("point1 == point2" +
//    (point1 == point2));

//Console.WriteLine("point1 == point2" +
//    (1 == 1));


int sum = 5 + 8;
string concatenated = "Hello" + " " + "there";

//var point1 = new Point(1, 5);
//var point2 = new Point(2, 4);
//var added = point1.Add(point2);
//var added = point1 + point2;

//Console.WriteLine("point1 == point2 " +
//    (point1 == point2));

int tenAsInt = 10;
decimal tenAsDecimal = tenAsInt;

decimal someDecimal = 20.01m;
int someInt = (int)someDecimal;

var tuple = Tuple.Create(10, 20);
//Point point3 = tuple;
//Point point3 = (Point)tuple;

var hash1 = 123.GetHashCode();
var hash2 = "abc".GetHashCode();
//Console.WriteLine(hash1);
//Console.WriteLine(hash2);

//var dictionary = new Dictionary<Point, string>();
//dictionary[new Point(10, 20)] = "abc";

//var dictionary = new Dictionary<Person,int>();
//var martin = new Person(6, "Martin");
//dictionary[martin] = 5;
//var theSameAsMartin = new Person(6, "Martin");
//Console.WriteLine(dictionary[martin]);
//Console.WriteLine(dictionary[theSameAsMartin]);
//Console.WriteLine(martin.GetHashCode());
//Console.WriteLine(theSameAsMartin.GetHashCode());

var dictionary = new Dictionary<Point, int>();
//var point1 = new Point(27, 1);
//dictionary[point1] = 99;
//var point2 = new Point(27, 1);
//var point3 = new Point(6, -1);
////Console.WriteLine(dictionary[point2]);
//Console.WriteLine(point1.GetHashCode());
//Console.WriteLine(point2.GetHashCode());
//Console.WriteLine(point3.GetHashCode());

//var person1 = new Person(6, "Martin");
//var person2 = new Person(6, "Martin");
//var person3 = new Person(7, "Bella");
//Console.WriteLine(person1.GetHashCode());
//Console.WriteLine(person2.GetHashCode());
//Console.WriteLine(person3.GetHashCode());

//var tuple1 = new Tuple<string, bool>("aaa", false);
//var tuple2 = Tuple.Create(10, true);
//var tuple3 = Tuple.Create(10, true);
//Console.WriteLine(tuple2 == tuple3);
//Console.WriteLine(tuple2.Equals(tuple3));
//Console.WriteLine(tuple2.GetHashCode());
//Console.WriteLine(tuple3.GetHashCode());

//var number = tuple2.Item1;
//// Tuples are Readonly
////tuple2.Item1 = 20;

//var valueTuple1 = new ValueTuple<int, string>(1, "bbb");
//var valueTuple2 = (Number: 5, Text: "ccc");
//valueTuple2.Item1 = 20;
//valueTuple2.Text = "ddd";

//var person = new Person("123456789", "John", 1982);
//person.Id = null;

var weatherData = new WeatherData(25.1m, 65);
Console.WriteLine(weatherData);

var warmerWeatherData = weatherData with { Temperature = 30 };

var rectangle = new Rectangle(10, 20);
//rectangle.A = 30;

Console.ReadKey();

//void MoveToRightBy1Unit(Point point)
//{
//    point.X++;
//}

//void SomeMethod<T>(T param) where T : struct
//{

//}
void SomeMethod<T>(T param) where T : class
{

}

struct FishyStruct
{
    public List<int> Numbers { get; init; }
}

readonly struct Point : IEquatable<Point>
{

    public int X { get; init; }
    public int Y { get; init; }

    public Point(int x, int y)
    {
        Y = y;
        X = x;
    }


    public override string ToString() => $"X: {X}, Y: {Y}";

    public static bool operator ==(Point point1, Point point2) =>
        point1.Equals(point2);
    public static bool operator !=(Point point1, Point point2) =>
        !point1.Equals(point2);

    public bool Equals (Point other)
    {
        return X == other.X && Y == other.Y;
    }

    public static implicit operator Point(Tuple<int, int> tuple) =>
        new Point(tuple.Item1, tuple.Item2);

    //public static explicit operator Point(Tuple<int, int> tuple) =>
    //    new Point(tuple.Item1, tuple.Item2);
    public override bool Equals(object? obj)
    {
        return obj is Point point &&
               Equals(point);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    //public Point Add(Point point2) =>
    //    new Point(X + point2.X, Y + point2.Y);
    public static Point operator +(Point a, Point b) =>
        new Point(a.X + b.X, a.Y + b.Y);
}
// All structs are sealed
//struct DerivedPoint : Point
//{

//}
class ObjectToTextConverter
{
    public string Convert(object obj)
    {
        Type type = obj.GetType();
        var properties = type
            .GetProperties()
            .Where(p => p.Name != "EqualityContract");

        return String.Join(
            ", ",
            properties
            .Select(property =>
            $"{property.Name} is {property.GetValue(obj)}"));
    }
}

public record Pet(string Name, PetType PetType, float Weight);
public record House(string Address, double Area, int Floors);
public enum PetType {  Cat, Dog, Fish };

public class Dog
{
    [StringLengthValidate(2, 10)]
    public string Name { get; } //length must be between 2 and 10
    public Dog(string name) => Name = name;
}
public class Person
{
    //[StringLengthValidate(2, 25)]
    //private Point _favoritePoint;
    //private Person _favoritePerson;
    public Person ClosestPerson { get; }
    public string Name { get; init; } //length must be between 2 and 25
    public string Id { get; init; }
    public int YearOfBirth { get; init; }
    public Person(string id, string name, int yearOfBirth)
    {
        if (string.IsNullOrEmpty(id) ||
            id.Length != 9 ||
            !id.All(character => char.IsDigit(character)))
        {
            throw new ArgumentException("Id is invalid");
        }
        if (string.IsNullOrEmpty (name) || name.Length < 2 || name.Length > 100)
        {
            throw new ArgumentException("Name is invalid");
        }
        if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
        {
            throw new ArgumentException("YearOfBirth is invalid");
        }
            Name = name;
        Id = id;
        YearOfBirth = yearOfBirth;
    }
    public override bool Equals(object? obj)
    {
        return obj is Person other &&
            Id == other.Id;
    }
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
    //public override int GetHashCode()
    //{
    //    return Id;
    //}

    //public Person(string name) => Name = name;
}

[AttributeUsage(AttributeTargets.Property)]
class StringLengthValidateAttribute: Attribute
{
    public int Min { get; }
    public int Max { get; }

    public StringLengthValidateAttribute(int min, int max)
    {
        Min = min; 
        Max = max;
    }
}

[Some(new int[] { 1, 2, 3 })]
public class SomeClass
{

}

public class SomeAttribute : Attribute
{
    public SomeAttribute(int[] numbers)
    {
        numbers = numbers;
    }
    public int[] Numbers { get; }
}

class Validator
{
    public bool Validate(object obj)
    {
        var type = obj.GetType();
        var propertiesToValidate = type
            .GetProperties()
            .Where(property =>
                Attribute.IsDefined(
                    property, typeof(StringLengthValidateAttribute)));
        foreach(var property in propertiesToValidate)
        {
            object? propertyValue = property.GetValue(obj);
            if(propertyValue is not string)
            {
                throw new InvalidOperationException(
                    $"Attribute {nameof(StringLengthValidateAttribute)}" +
                    $" can only be applied to string");
            }
            var value = (string)propertyValue;
            var attribute = (StringLengthValidateAttribute)
                property.GetCustomAttributes(
                    typeof(StringLengthValidateAttribute), true).First();
            if(value.Length < attribute.Min || value.Length > attribute.Max)
            {
                Console.WriteLine($"Property {property.Name} is invalid." +
                    $"Value is {value}");
                return false;
            }
        }
        return true;
    }
}

// Properties are readonly with positional records
public record WeatherData(decimal Temperature, int Humidity);

public readonly record struct Rectangle(int A, int B);

// With regular records, we can make Properties writable
// and define our own methods.
//public record WeatherData
//{
//    public decimal Temperature { get; set; }
//    public int Humidity { get; }

//    public WeatherData(decimal temperature, int humidity)
//    {
//        Temperature = temperature;
//        Humidity = humidity;
//    }
//    public void SomeMethod()
//    {

//    }
//}

//public class WeatherData : IEquatable<WeatherData?>
//{
//    public decimal Temperature { get; }
//    public int Humidity { get; }

//    public WeatherData(decimal temperature, int humidity)
//    {
//        Temperature = temperature;
//        Humidity = humidity;
//    }
//    public override string ToString() =>
//        $"Temperature: {Temperature}, Humidity: {Humidity}";

//    public override bool Equals(object? obj)
//    {
//        return Equals(obj as WeatherData);
//    }

//    public bool Equals(WeatherData? other)
//    {
//        return other is not null &&
//               Temperature == other.Temperature &&
//               Humidity == other.Humidity;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(Temperature, Humidity);
//    }

//    public static bool operator ==(WeatherData? left, WeatherData? right)
//    {
//        return EqualityComparer<WeatherData>.Default.Equals(left, right);
//    }

//    public static bool operator !=(WeatherData? left, WeatherData? right)
//    {
//        return !(left == right);
//    }
//}