//var number = 0;
//
//var word = "abc";
//word += "d";

//while(number < 10)
//{
//    //number = number + 1;
//    //number += 1;
//    //number++;
//    ++number;
//    Console.WriteLine($"Number is {number}");
//}
//
//Console.WriteLine("The loop is finished.");

Console.WriteLine("Enter a word");
var userInput = Console.ReadLine();

while(userInput.Length < 15)
{
    userInput += 'a';
    Console.WriteLine(userInput);
}

Console.WriteLine("The loop is finished");
Console.ReadKey();


class Exercise
{
    int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
    {

        int runSum = 0;
        while (firstNumber <= lastNumber){

            runSum += firstNumber;
            firstNumber++;
        }

        return runSum;
    }
}

class DoWhileLoop
{
    void Demonstration()
    {
        string word;
        do
        {
            Console.WriteLine("Enter a word longer than 10 letters");
            word = Console.ReadLine();

        } while (word.Length <= 10);
        Console.WriteLine("The loop is finished.");

    }
}

class DoWhileExercise
{
    string RepeatCharacter(char character, int targetLength)
    {
        string result = "";
        do
        {
            result += character;
        } while (result.Length < targetLength);
        return result;
    }
}

