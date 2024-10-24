﻿//Console.WriteLine("Cores count: " + Environment.ProcessorCount);
//Console.WriteLine("Main thread's ID: " + Thread.CurrentThread.ManagedThreadId);

//Thread thread1 = new Thread(() => PrintPluses(200));
//Thread thread2 = new Thread(() => PrintMinuses(200));

//thread1.Start();
//thread2.Start();

//PrintPluses(30);
//PrintMinuses(30);

//Console.WriteLine("Program is finished.");
//const int iterations = 100;
//Stopwatch stopwatch = Stopwatch.StartNew();

//for (int i = 0; i < iterations; i++)
//{
//    ThreadPool.QueueUserWorkItem(PrintA);
//}
//stopwatch.Stop();
//Console.WriteLine("Took: " + stopwatch.ElapsedMilliseconds);
//Task task1 = Task.Run(() => PrintPluses(200));
//Task task2 = Task.Run(() => PrintMinuses(200));
//task1.Start();
//task2.Start();
//Task<int> taskWithResult = Task.Run(() => CalculateLength("Hello there"));
//Console.WriteLine("Length is: " + taskWithResult.Result);
//var task = Task.Run(() =>
//{
//    Thread.Sleep(1000);
//    Console.WriteLine("Task is finished");
//});
//var task2 = Task.Run(() =>
//{
//    Thread.Sleep(1000);
//    Console.WriteLine("Task 2 is finished.");
//});
//Task.WaitAll(task, task2);
//Console.WriteLine("After the task.");

//Task taskContinuation =
//    Task.Run(() => CalculateLength("Hello there"))
//    .ContinueWith(taskWithResult =>
//    Console.WriteLine("Length is " + taskWithResult.Result))
//    .ContinueWith(completedTask =>
//    {
//        Thread.Sleep(500);
//        Console.WriteLine("The second continuation.");
//    });
//var tasks = new[]
//{
//    Task.Run(() => CalculateLength("Hello there")),
//    Task.Run(() => CalculateLength("hi")),
//    Task.Run(() => CalculateLength("hola")),
//};

//var continuationTask = Task.Factory.ContinueWhenAll(
//    tasks,
//    completedTasks => Console.WriteLine(
//        string.Join(", ", completedTasks.Select(task => task.Result))));

//string userInput;
//do
//{
//    Console.WriteLine("Enter a command:");
//    userInput = Console.ReadLine();
//} while (userInput != "exit");
//var cancellationTokenSource = new CancellationTokenSource();
//var task = Task.Run(
//    () => NeverendingMethod(cancellationTokenSource.Token),
//    cancellationTokenSource.Token);

//string userInput;
//do
//{
//    userInput = Console.ReadLine();
//} while (userInput != "cancel");

//cancellationTokenSource.Cancel();


Console.WriteLine("Main thread's ID: " + Thread.CurrentThread.ManagedThreadId);


var task = Task.Run(() => Divide(2, 0))
    .ContinueWith(
    faultedTask =>
    {
        faultedTask.Exception.Handle(ex =>
        {
            Console.WriteLine("Division task finsihed");
            if (ex is ArgumentNullException)
            {
                Console.WriteLine("Arguments can't be null");
                return true;
            }
            if (ex is DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero.");
                return true;
            }
            Console.WriteLine("Unexpected exception type.");
            return false;
        });
    },
    TaskContinuationOptions.OnlyOnFaulted);
        



Thread.Sleep(1000);
Console.WriteLine("Program is finished.");
Console.ReadKey();

static float Divide(int? a, int? b)
{
    if (a is null || b is null)
    {
        throw new ArgumentNullException("Arguments cannot be null.");
    }
    if (b == 0)
    {
        throw new DivideByZeroException("Division by zero is not allowed.");
    }
    return a.Value / (float)b.Value;
}

static void MethodThrowingException()
{
    Console.WriteLine("Inside MethodThrowingException");
    throw new Exception("Some error message");
}

static void NeverendingMethod(CancellationToken cancellationToken)
{
    while (true)
    {
        cancellationToken.ThrowIfCancellationRequested();
        Console.WriteLine("Working...");
        Thread.Sleep(1500);
    }
}


static int CalculateLength(string input)
{
    Console.WriteLine("CalculateLength thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    Thread.Sleep(4000);
    return input.Length;
}

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
