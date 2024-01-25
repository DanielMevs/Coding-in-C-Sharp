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
