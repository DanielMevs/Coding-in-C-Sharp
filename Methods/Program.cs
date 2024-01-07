var result = Add(10, 5);
Console.WriteLine("10 + 5 = " + result);

var userChoice = Console.ReadLine();

bool isLong = IsLong(userChoice);
Console.WriteLine("Result of IsLong: " + isLong);

Console.ReadKey();

int Add(int a, int b)
{
    return a + b;

}

bool IsLong(string input)
{
    return input.Length > 10;
}
