//Console.WriteLine("Enter a Number:");
//string input = Console.ReadLine();
//try
//{
//    int number = ParseStringToInt(input);
//    var result = 10 / number;
//    Console.WriteLine($"10 / {number} is " + result);
//}
//catch(FormatException ex)
//{
//    Console.WriteLine(
//        "Wrong format. Input string is not parsable to int." +
//        $"Exception message: {ex.Message}");
//}
//catch(DivideByZeroException ex)
//{
//    Console.WriteLine("Division by zero is an invalid operation. " +
//        "Exception message: " + ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Unexpected error occured. " +
//        "Exception message: " + ex.Message);
//}
//finally
//{
//    Console.WriteLine("Finally block is being excuted.");
//}

//var result = GetFirstElement(new int[0]);

//var invalidPersonObject = new Person("", -100);

//var emptyCollection = new List<int>();
//var firstElement = GetFirstElement(emptyCollection);
//var firstUsingLinq = emptyCollection.First();

//var numbers = new int[] { 1, 2, 3, 4 };
//var forth = numbers[4];

//bool has7 = CheckIfContains(7, numbers);

//RecursiveMethod(1);
//try
//{
//    var result = IsFirstElementPositive(null);
//}
//catch(ArgumentNullException ex)
//{

//}

//Console.WriteLine("Enter a number:");
//string input = Console.ReadLine();

//try
//{
//    int number = int.Parse(input);
//    var result = 10 / number;
//    Console.WriteLine($"10 / {number} is {result}");
//}
//catch(DivideByZeroException ex)
//{
//    int.Parse("not an int");
//    Console.WriteLine("Division by zero is an invalid operation. " +
//        "Exception message: " + ex.Message);
//}
//catch(FormatException ex)
//{
//    Console.WriteLine(
//        "Wrong format. Input string is not parsable to int. " + 
//        "Exception message: " + ex.Message);
//}

//try
//{
//    var dataFromWeb = SendHttpRequest("www.someAddress.com/get/someResource");
//}
//catch(HttpRequestException ex) when (ex.Message == "403")
//{
//    Console.WriteLine("It was forbidden to access the resource.");
//    throw;
//}
//catch(HttpRequestException ex) when (ex.Message == "404")
//{
//    Console.WriteLine("The resource was not found.");
//}
//catch(HttpRequestException ex) when (ex.Message.StartsWith("4"))
//{
//    Console.WriteLine("Some kind of client error.");
//}
//catch(HttpRequestException ex) when (ex.Message == "500")
//{
//    Console.WriteLine("The server has experienced an internal error.");
//    throw;
//}
//object SendHttpRequest(string v)
//{
//    throw new NotImplementedException();
//}

using System.Runtime.Serialization;

try
{
    ComplexMethod();
}
catch(JsonParsingException ex)
{
    Console.WriteLine("Unable to parse JSON. JSON body is: " + ex.JsonBody);
    throw;
}

Console.ReadKey();

void ComplexMethod()
{
    //// step 1: connecting
    //throw new ConnectionException("Cannot connect to a service");

    //// step 2: authorizing
    //throw new AuthorizationException("Cannot authorize the user.");

    //// step 3: retrieving data as JSON
    //throw new DataAccessException("Cannot retrieve data");
    
    // step 4: parsing the JSON to come C# type
    throw new JsonParsingException("Cannot parse JSON data.");
}

bool IsFirstElementPositive(IEnumerable<int> numbers)
{
    try
    {
        var firstElement = GetFirstElement(numbers);
        return firstElement > 0;
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("The collection is empty!");
        return true;
    }
    catch (NullReferenceException ex)
    {
        //throw;
        throw new ArgumentNullException("The collection is null.", ex);
    }
}
void RecursiveMethod(int counter)
{
    Console.WriteLine("I'm going to call myself. Counter is: " + counter);
    if (counter < 10)
    {
        RecursiveMethod(counter + 1);
    }
}

bool CheckIfContains(int value, int[] numbers)
{
    throw new NotImplementedException();
}


int ParseStringToInt(string input)
{
    return int.Parse(input);

}

int GetFirstElement(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        return number;
    }
    throw new InvalidOperationException("The collection cannot be empty.");
}

public class JsonParsingException : Exception
{
    public string JsonBody { get; }
    public JsonParsingException()
    {

    }
    public JsonParsingException(string message) : base(message)
    {

    }
    public JsonParsingException(
        string message,
        string jsonBody,
        Exception innerException) : base(message, innerException)
    {
        JsonBody = jsonBody;
    }
    public JsonParsingException(string message, Exception innerException)
        : base(message, innerException)
    {

    }
}

[Serializable]
public class CustomException : Exception
{
    public int StatusCode { get;  }
    protected CustomException(
        SerializationInfo info,
        StreamingContext context ): base(info, context)
    {

    }
    public CustomException()
    {
        
    }
    public CustomException(string message, int statusCode) : base(message)
    {
        StatusCode = statusCode;
    }
    public CustomException(
        string message,
        int statusCode,
        Exception innerException) : base(message, innerException)
    {
        StatusCode = statusCode;
    }

    public CustomException(string message) : base(message)
    {

    }
    public CustomException(string message, Exception innerException) 
        : base(message, innerException)
    {

    }
}

//public class PersonDataReader
//{
//    private readonly IPeopleRepository _peopleRepository;
//    private readonly ILogger _logger;

//    public PersonDataReader(
//        IPeopleRepository personRepository,
//        ILogger logger)
//    {
//        _peopleRepository = personRepository;
//        _logger = logger;
//    }
//    public Person ReadPersonData(int personId)
//    {
//        try
//        {
//            return _peopleRepository.Read(personId);
//        }
//        catch(Exception ex)
//        {
//            _logger.Log(ex);
//            throw;
//        }
//    }
//}
//public interface IPeopleRepository
//{
//    Person Read(int personId);
//}
//public interface ILogger
//{
//    void Log(Exception ex);
//}

class Person
{
    public string Name { get; }
    public int YearOfBirth { get; }

    public Person(string name, int yearOfBirth)
    {
        if (name == null) 
        {
            throw new ArgumentNullException("The name cannot be null.");
        }
        if(name == string.Empty)
        {
            throw new ArgumentException("The name cannot be empty.");
        }
        if(yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException("The year of birth must be " +
                "between 1900 and the current year.");
        }
        Name = name;
        YearOfBirth = yearOfBirth;
    }
}

