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
try
{
    var result = IsFirstElementPositive(null);
}
catch(ArgumentNullException ex)
{

}


Console.ReadKey();

int GetFirstElement(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        return number;
    }
    throw new InvalidOperationException("The collection cannot be empty.");
}
bool IsFirstElementPositive(IEnumerable<int> numbers)
{
    try
    {
        var firstElement = GetFirstElement(numbers);
        return firstElement > 0;
    }
    catch(InvalidOperationException ex)
    {
        Console.WriteLine("The collection is empty!");
        return true;
    }
    catch(NullReferenceException ex)
    {
        //throw;
        throw new ArgumentNullException("The collection is null.", ex);
    }
}
void RecursiveMethod(int counter)
{
    Console.WriteLine("I'm going to call myself. Counter is: " + counter);
    if(counter < 10)
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

