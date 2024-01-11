Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

if (userChoice == "S")
{
    PrintSelectedOption("See all TODOs");
}
else if (userChoice == "A")
{
    PrintSelectedOption("Add a TODO");
}
else if (userChoice == "R")
{
    PrintSelectedOption("Remove a TODO");
}
else if (userChoice == "E")
{
    PrintSelectedOption("Exit");
}
else
{
    Console.WriteLine("Invalid choice");
}



var result = Add(10, 5);
Console.WriteLine("10 + 5 = " + result);

var userChoice2 = Console.ReadLine();

bool isLong = IsLong(userChoice2);
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

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}