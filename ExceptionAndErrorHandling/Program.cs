Console.WriteLine("Enter a Number:");
string input = Console.ReadLine();
try
{
    int number = ParseStringToInt(input);
    var result = 10 / number;
    Console.WriteLine($"10 / {number} is " + result);
}
catch(FormatException ex)
{
    Console.WriteLine(
        "Wrong format. Input string is not parsable to int." +
        $"Exception message: {ex.Message}");
}
catch(DivideByZeroException ex)
{
    Console.WriteLine("Division by zero is an invalid operation. " +
        "Exception message: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Unexpected error occured. " +
        "Exception message: " + ex.Message);
}
finally
{
    Console.WriteLine("Finally block is being excuted.");
}


Console.ReadKey();

int ParseStringToInt(string input)
{
    return int.Parse(input);
  
}