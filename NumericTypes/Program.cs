var twoBillion = 2_000_000_000;

int sumSoFar = 1_900_000_000;
int nextTransaction = 1_000_000_000;

long sumAfterTransaction =
    (long)sumSoFar + (long)nextTransaction;

if (sumSoFar + nextTransaction > twoBillion)
{
    Console.WriteLine("Transaction blocked");
}
else
{
    Console.WriteLine("Transaction executed.");
}

//checked
//{
//    // will be checked
//    if (sumSoFar + nextTransaction > twoBillion)
//    {
//        Console.WriteLine("Transaction blocked");
//    }
//    else
//    {
//        Console.WriteLine("Transaction executed.");
//    }
//    unchecked
//    {
//        //will not be checked
//    }
//}
SomeMethodWithCheckedContext(twoBillion, twoBillion);

Console.ReadKey();

void SomeMethodWithCheckedContext(int a, int b)
{
    // The checked scope does not affect any method
    // that is called within it.
    //checked
    //{
    //    var result = Add(a, b);
    //}
    var result = Add(a, b);
}

// If we want the result checked, we must do it 
// within the Add method.
//int Add(int a, int b) => a + b;

int Add(int a, int b)
{
    checked
    {
        return a + b;
    }
}