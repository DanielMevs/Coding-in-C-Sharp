//for(int i = 10; i > 5; i--)
//{
//    Console.WriteLine("Hello");
//}

//for(var i = 0; i < 100; i++)
//{
//    Console.WriteLine("i is " + i);
//    if(i > 25)
//    {
//        break;
//    }
//}

//for(var i = 0; i < 20; i++)
//{
//    if(i % 3 == 0)
//    {
//        continue;
//    }
//    Console.WriteLine("i is " + i);
//}

for(int i = 0; i < 4; ++i)
{
    for (int j = 0; j < 3; ++j)
    {
        Console.WriteLine($"i is {i}, j is {j}");
    }
}

Console.WriteLine("The loop is finished");
Console.ReadKey();

class Exercise
{
    int Factorial(int number)
    {
        int result = 1;
        for (int i = number; i > 0; i--)
        {
            result *= i;
        }
        return result;
    }
}