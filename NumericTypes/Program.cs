//var twoBillion = 2_000_000_000;

//int sumSoFar = 1_900_000_000;
//int nextTransaction = 1_000_000_000;

//long sumAfterTransaction =
//    (long)sumSoFar + (long)nextTransaction;

//if (sumSoFar + nextTransaction > twoBillion)
//{
//    Console.WriteLine("Transaction blocked");
//}
//else
//{
//    Console.WriteLine("Transaction executed.");
//}

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
//SomeMethodWithCheckedContext(twoBillion, twoBillion);

Console.WriteLine(0.3d == (0.2d + 0.1d));
Console.WriteLine(AreEqual(0.3d, 0.2d + 0.1d, 0.000001d));

Console.WriteLine(0d/0d);
Console.WriteLine(10d / 0d);

Console.ReadKey();

bool AreEqual(double a, double b, double tolerance) =>
    Math.Abs(a - b) < tolerance;

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