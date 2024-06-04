using System.ComponentModel.DataAnnotations;

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

// move to right by 1
//point.X++;

//MoveToRightBy1Unit(point);

//var dateTime = new DateTime(2023, 6, 7);
//dateTime.Day += 7;

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

struct Point/* : IComparable<Point>*/
{
    //public Point ClosetPoint { get; }
    public int X { get; init; }
    public int Y { get; init; }

    public Point(int x, int y)
    {
        Y = y;
        X = x;
    }
    public override string ToString() => $"X: {X}, Y: {Y}";
    //~Point()
    //{

    //}
    //public Point()
    //{
    //    X = 1;
    //    Y = 2;
    //}


    //public int CompareTo(Point other)
    //{
    //    throw new NotImplementedException();
    //}
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
    public int Id { get; init; }
    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }


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