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

using System.Diagnostics;

Console.WriteLine(0.3d == (0.2d + 0.1d));
Console.WriteLine(AreEqual(0.3d, 0.2d + 0.1d, 0.000001d));

Console.WriteLine(0d/0d);
Console.WriteLine(10d / 0d);

// Decimals
Console.WriteLine(0.3m == (0.2m + 0.1m));

int iterations = 30_000_000;
var resultForDouble = DoubleTest(iterations);
var resultForDecimal = DecimalTest(iterations);

Console.WriteLine($"Calculation of {iterations} elements.");
Console.WriteLine($"For double it took {resultForDouble} ticks.");
Console.WriteLine($"For decimal it took {resultForDecimal} ticks.");

var differenceScaled = (double)resultForDecimal / (double)resultForDouble;
Console.WriteLine($"Decimal took {differenceScaled:00.00} times as much time");

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

long DoubleTest(int iterations)
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    double z = 0;
    for(int i = 0; i < iterations; i++)
    {
        double x = i;
        double y = x * i;
        z += y;
    }
    stopwatch.Stop();
    return stopwatch.ElapsedTicks;
}
long DecimalTest(int iterations)
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    decimal z = 0;
    for(int i = 0; i < iterations; i++)
    {
        decimal x = i;
        decimal y = x * i;
        z += y;
    }
    stopwatch.Stop();
    return stopwatch.ElapsedTicks;
}