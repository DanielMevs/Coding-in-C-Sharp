//Console.WriteLine("Cores count: " + Environment.ProcessorCount);
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


//var task = Task.Run(() => Divide(2, 0))
//    .ContinueWith(
//    faultedTask =>
//    {
//        faultedTask.Exception.Handle(ex =>
//        {
//            Console.WriteLine("Division task finsihed");
//            if (ex is ArgumentNullException)
//            {
//                Console.WriteLine("Arguments can't be null");
//                return true;
//            }
//            if (ex is DivideByZeroException)
//            {
//                Console.WriteLine("Can't divide by zero.");
//                return true;
//            }
//            Console.WriteLine("Unexpected exception type.");
//            return false;
//        });
//    },
//    TaskContinuationOptions.OnlyOnFaulted);
////////////////////////////////////////////
//var task = new Task(() => Divide(10, 2));

//task.ContinueWith(faultedTask =>
//    Console.WriteLine("Success"),
//    TaskContinuationOptions.OnlyOnRanToCompletion);

//task.ContinueWith(faultedTask =>
//    Console.WriteLine("Exception thrown: " + faultedTask.Exception.Message),
//    TaskContinuationOptions.OnlyOnFaulted);

//task.Start();
//////////////////////////////////////////////////////////
//Console.WriteLine("Main thread's ID: " + Thread.CurrentThread.ManagedThreadId);

//var cancellationTokenSource = new CancellationTokenSource();
//var task = Task.Run(
//    () => NeverendingMethod(cancellationTokenSource.Token),
//    cancellationTokenSource.Token)
//    .ContinueWith(canceledTask =>
//        Console.WriteLine($"Task with ID {canceledTask.Id} has been canceled."),
//        TaskContinuationOptions.OnlyOnCanceled);

//string userInput;
//do
//{
//    userInput = Console.ReadLine();
//} while (userInput != "cancel");

//cancellationTokenSource.Cancel();

//Thread.Sleep(2000);
//Console.WriteLine("Program is finished.");
///////////////////////////////////////////
//var counter = new Counter();
//var tasks = new List<Task>();

//for(int i = 0; i < 10; i++)
//{
//    tasks.Add(Task.Run(() => counter.Increment()));
//}
//for(int i = 0;i < 10; i++)
//{
//    tasks.Add(Task.Run(() => counter.Decrement()));
//}

//Task.WaitAll(tasks.ToArray());
//Console.WriteLine("Counter value is: " + counter.Value);

// synchronous
//var result = CalculateLength("Hello");
//Print(result);
//Console.WriteLine("The process is finished.");
////////////////////////////////////////////////////
//var task = Task.Run(() => CalculateLength("Hello"))
//    .ContinueWith(completedTask => Print(completedTask.Result))
//    .ContinueWith(previousContinuation =>
//        Console.WriteLine("The process is finished."));

//string userInput;
//do
//{
//    userInput = Console.ReadLine();
//} while (userInput != "stop");

//Console.WriteLine("Program is finished.");
////////////////////////////////////////////////

var task = RunHeavyProcess();

Console.WriteLine("Doing other work");
Console.WriteLine("Doing even more work");

Console.ReadKey();

static async Task RunHeavyProcess()
{
    string result = await HeavyCalculation();
    Console.WriteLine(result);
}

static async Task<string> HeavyCalculation()
{
    Console.WriteLine("Starting heavy calculation");
    Thread.Sleep(2000);
    return "Done!";
}

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
    //Console.WriteLine("CalculateLength thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine("Starting the CalculateLength method");
    Thread.Sleep(4000);
    return input.Length;
}

static void Print(int result)
{
    Console.WriteLine("Starting the Print method");
    Thread.Sleep(2000);
    Console.WriteLine($"The result is {result}");
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

class Counter
{
    private object _valueLock = new object();
    public int Value { get; private set; }
    public void Increment()
    {
        lock (_valueLock)
        {
            Value++;
        }
    }
    public void Decrement()
    {
        lock (_valueLock)
        {
            Value--;
        }
    }
}