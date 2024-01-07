Console.WriteLine("Welcome!");
Console.WriteLine("Input the first number: ");
var numOne = Console.ReadLine();
Console.WriteLine("Input the second number: ");
var numTwo = Console.ReadLine();


Console.WriteLine("What do you want to do with those numbers?\n");
Console.WriteLine("[A] dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");


var userInput = Console.ReadLine();
Console.WriteLine(PrintValues(userInput, numOne, numTwo));
Console.WriteLine("Press any key to close" );

string PrintValues(string sign, string a, string b)
{
    int numOne = int.Parse(a);
    int numTwo = int.Parse(b);
    int result;

    string operatorSign;
    if(sign.ToUpper() == "A")
    {
        result = numOne + numTwo;
        operatorSign = "+";
    }
    else if(sign.ToUpper() == "S")
    {
        result = numOne - numTwo;
        operatorSign = "-";
    }
    else if(sign.ToUpper() == "M")
    {
        result = numOne * numTwo;
        operatorSign = "*";
    }
    else
    {
        return "Invalid option.";
    }

    return a + operatorSign + b + "=" + result;
}

Console.ReadKey();


