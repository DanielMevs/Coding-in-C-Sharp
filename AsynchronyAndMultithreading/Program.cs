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

////////////////////////////////////////////////
//Console.WriteLine("Main thread's ID: " + Thread.CurrentThread.ManagedThreadId);
//var task = RunHeavyProcess();

//Console.WriteLine("Doing other work");
//Console.WriteLine("Doing even more work");
////////////////////////////////////////
//await Process("Hello");

//string userInput;
//do
//{
//    Console.WriteLine("Enter a command:");
//    userInput = Console.ReadLine();
//} while (userInput != "stop");

//Console.WriteLine("Program is finished.");
//////////////////////////


using System.Text.Json;

try
{
    var quote = await GetQuote();
}
catch(Exception ex)
{
    Console.WriteLine($"Exception thrown: {ex.Message}");
}


Console.WriteLine("Program is finished.");
Console.ReadKey();

async Task<Quote> GetQuote()
{
    using var httpClient = new HttpClient();
    var endpoint = $"https://favqs.com/api/qotd";

    HttpResponseMessage response = await httpClient.GetAsync(endpoint);
    response.EnsureSuccessStatusCode();
    string json = await response.Content.ReadAsStringAsync();
    var root = JsonSerializer.Deserialize<Root>(json);

    return root.quote;
}



static async Task Process(string input)
{
    try
    {
        var length = await CalculateLengthAsync(input);
        await PrintAsync(length);
        Console.WriteLine("The process is finished.");
    }
    catch(NullReferenceException ex)
    {
        Console.WriteLine("The input can't be null.");
    }
    
}

static async Task PrintAsync(int result)
{
    Console.WriteLine("Starting the Print method");
    await Task.Delay(2000);
    Console.WriteLine($"The result is {result}");
}


static async Task<int> CalculateLengthAsync(string input)
{
    //Console.WriteLine("CalculateLength thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine("Starting the CalculateLength method");
    await Task.Delay(4000);
    return input.Length;
}

static async Task RunHeavyProcess()
{
    Console.WriteLine("RunHeavyProcess thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    string result = await HeavyCalculation();
    Console.WriteLine(result);
}

static async Task<string> HeavyCalculation()
{
    Console.WriteLine("HeavyCalculation thread's ID: " + Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine("Starting heavy calculation");
    await Task.Delay(2000);
    Console.WriteLine("HeavyCalculation thread's ID: " + Thread.CurrentThread.ManagedThreadId);
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
    Thread.Sleep(2000);
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

public record Quote(
int id,
bool dialogue,
bool @private,
IReadOnlyList<string> tags,
string url,
int favorites_count,
int upvotes_count,
int downvotes_count,
string author,
string author_permalink,
string body
);

public record Root(
DateTime qotd_date,
Quote quote
);

