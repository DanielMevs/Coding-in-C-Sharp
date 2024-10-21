//Console.WriteLine("Cores count: " + Environment.ProcessorCount);
//Console.WriteLine("Main thread's ID: " + Thread.CurrentThread.ManagedThreadId);

//Thread thread1 = new Thread(() => PrintPluses(200));
//Thread thread2 = new Thread(() => PrintMinuses(200));

//thread1.Start();
//thread2.Start();

//PrintPluses(30);
//PrintMinuses(30);

//Console.WriteLine("Program is finished.");

using System.Diagnostics;

const int iterations = 100;
Stopwatch stopwatch = Stopwatch.StartNew();

for (int i = 0; i < iterations; i++)
{
    //Thread newThread = new Thread(PrintA);
    //newThread.Start();
    ThreadPool.QueueUserWorkItem(PrintA);
}
stopwatch.Stop();
Console.WriteLine("Took: " + stopwatch.ElapsedMilliseconds);

Console.ReadKey();

static void PrintA(object obj)
{
    Console.Write("A");
}
static void PrintPluses(int n)
{
    Console.WriteLine("\nPrintPluses thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    for (int i = 0; i < n; i++)
    {
        Console.Write("+");
    }
}

static void PrintMinuses(int n)
{
    Console.WriteLine("\nPrintMinuses thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    for (int i = 0; i < n; i++)
    {
        Console.Write("-");
    }
}
