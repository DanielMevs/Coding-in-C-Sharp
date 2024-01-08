var userChoice = Console.ReadLine();

if(userChoice.Length <= 3)
{
    Console.WriteLine("Short answer");
}
else if(userChoice.Length < 10)
{
    Console.WriteLine("Medium anwer");

}
else
{
    Console.WriteLine("Long answer");
}


if(userChoice.Length == 0)
{
    Console.WriteLine("Empty choice!");
    int number = 5;
    Console.WriteLine(number);
    var word = "ABC";
    if(word.Length > 0)
    {
        Console.WriteLine(number);
        Console.WriteLine(userChoice);
    }
}
else
{
    int number = 10;
    Console.WriteLine("Non-empty choice: " + userChoice);
    //Console.WriteLine(number);
}
Console.WriteLine("Your choice is: " + userChoice);

Console.ReadKey();


class Exercise
{
    int AbsoluteOfSum(int numOne, int numTwo)
    {
        int result = numOne + numTwo;
        if (result < 0)
        {
            return result * -1;
        }
        return result;
    }
}