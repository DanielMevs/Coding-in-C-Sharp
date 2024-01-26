//var calculator = new Calculator();
//Console.WriteLine($"1 + 2 is {calculator.Add(1,2)}");
//Console.WriteLine($"1 - 2 is {calculator.Subtract(1,2)}");


//Static methods belong to a class as a whole, not instance-specific
Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");
Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
Console.WriteLine($"1 - 2 is {Calculator.Subtract(1, 2)}");


//Object Initializers
// object initializers only work when a field has a public setter
var person = new Person
{
    Name = "Adam",
    YearOfBirth = 1981
};
person.Name = "John";
//person.YearOfBirth = 1992;

Console.ReadKey();
class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; init; }

    //public Person(string name)
    //{
    //    Name = name;
    //}
}

public class DailyAccountState
{
    public int InitialState { get; }

    public int SumOfOperations { get; }

    public DailyAccountState(
        int initialState,
        int sumOfOperations)
    {
        InitialState = initialState;
        SumOfOperations = sumOfOperations;
    }

    public int EndOfDayState => InitialState + SumOfOperations;
    public string Report => $"Day: {DateTime.Now.Day}, " + $"month: {DateTime.Now.Month}, " +
        $"year: {DateTime.Now.Year}, " +
        $"initial state: {InitialState}, " +
        $"end of day state: {EndOfDayState}";


}
// Stateless
// Static classes only contain static methods.
static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}

public static class NumberToDayOfWeekTranslator
{
    public static string Translate(int dayNumber)
    {
        switch (dayNumber)
        {
            case 1:
                return "Monday";
            case 2:
                return "Tuesday";
            case 3:
                return "Wednesday";
            case 4:
                return "Thursday";
            case 5:
                return "Friday";
            case 6:
                return "Saturday";
            case 7:
                return "Sunday";
            default:
                return "Invalid day of the week";
        }
    }
}