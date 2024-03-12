Console.WriteLine("Enter a Number:");
string input = Console.ReadLine();
try
{
    var number = ParseStringToInt(input);
    Console.WriteLine(
        "String successfully parsed, the result is " + number);
}
catch(Exception ex)
{
    Console.WriteLine(
        $"An exception was thrown. Exception message: {ex.Message}");
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