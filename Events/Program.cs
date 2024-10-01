const int threshold = 30_000;
var goldPriceReader = new GoldPriceReader();

bool areNotificationsEnabled = true;
if(areNotificationsEnabled)
{
    var emailPriceChangeNotifier = new EmailPriceChangeNotifier(
        threshold);

    var pushPriceChangeNotifier = new PushPriceChangeNotifier(
            threshold);



    goldPriceReader.PriceRead += emailPriceChangeNotifier.Update;
    goldPriceReader.PriceRead += pushPriceChangeNotifier.Update;
    for (int i = 0; i < 3; ++i)
    {
        goldPriceReader.ReadCurrentPrice();
    }

    goldPriceReader.PriceRead -= emailPriceChangeNotifier.Update;
    goldPriceReader.PriceRead -= pushPriceChangeNotifier.Update;
}


//SomeMethod methods = Test1;
//SomeMethod methods2 = Test2;
//methods += Test3;
//methods -= Test3;

//methods(10, 2);

Console.ReadKey();

void Test1(int number1, int number2) { }
void Test2(int a, int b, int c) { }
void Test3(int number1, int number2) { }

public delegate void PriceRead(decimal price);

public class PriceReadEventArgs : EventArgs
{
    public decimal Price { get; }
    public PriceReadEventArgs(decimal price)
    {
        Price = price;
    }
}

public class GoldPriceReader 
{
    public event EventHandler<PriceReadEventArgs>? PriceRead;
        
    public void ReadCurrentPrice()
    {
        var currentGoldPrice = new Random().Next(
            20_000,50_000);

        OnPriceRead(currentGoldPrice);

    }

    private void OnPriceRead(decimal price)
    {
        PriceRead?.Invoke(
            this,
            new PriceReadEventArgs(price));
    }

   
}

public class EmailPriceChangeNotifier
{
    private readonly decimal _notifiationThreashold;

    public EmailPriceChangeNotifier(
        decimal notifiationThreashold)
    {
        _notifiationThreashold = notifiationThreashold;
    }
    public void Update(
        object? sender, PriceReadEventArgs eventArgs)
    {
        if(eventArgs.Price > _notifiationThreashold)
        {
            //imagine this is actually sending an email
            Console.WriteLine(
                $"Sending an email saying that " +
                $"the gold price exceed {_notifiationThreashold}" +
                $"and is now {eventArgs.Price}\n");
        }
    }
}

public class PushPriceChangeNotifier
{
    private readonly decimal _notificationThreashold;

    public PushPriceChangeNotifier( decimal notificationThreashold )
    {
        _notificationThreashold = notificationThreashold;
    }

    public void Update(
        object? sender, PriceReadEventArgs eventArgs)
    {
        if(eventArgs.Price > _notificationThreashold)
        {
            Console.WriteLine(
                $"Sending a push notification saying that " +
                $"the gold price exceeded {_notificationThreashold}" +
                $"and is now {eventArgs.Price}\n");
        }
    }
}

public interface IObserver<TData>
{
    void Update(TData data);
}

public interface IObservable<TData>
{
    void AttachObserver(IObserver<TData> observer);
    void DetachObserver(IObserver<TData> observer);
    void NotifyObservers();
}


public delegate void SomeMethod(int a, int b);
