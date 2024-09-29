using System.Runtime.Intrinsics.Arm;

const int threshold = 30_000;

var emailPriceChangeNotifier = new EmailPriceChangeNotifier(
        threshold);

var pushPriceChangeNotifier = new PushPriceChangeNotifier(
        threshold);

var goldPriceReader = new GoldPriceReader();
//goldPriceReader.AttachObserver(emailPriceChangeNotifier);
//goldPriceReader.AttachObserver(pushPriceChangeNotifier);

//for(int i = 0; i < 3; ++i)
//{
//    goldPriceReader.ReadCurrentPrice();
//}

//Console.WriteLine("Turning push notifications off");

//goldPriceReader.DetachObserver(pushPriceChangeNotifier);
goldPriceReader.PriceRead += emailPriceChangeNotifier.Update;
goldPriceReader.PriceRead += pushPriceChangeNotifier.Update;
for (int i = 0; i < 3; ++i)
{
    goldPriceReader.ReadCurrentPrice();
}

SomeMethod methods = Test1;
//SomeMethod methods2 = Test2;
methods += Test3;
methods -= Test3;

methods(10, 2);

Console.ReadKey();

void Test1(int number1, int number2) { }
void Test2(int a, int b, int c) { }
void Test3(int number1, int number2) { }

public delegate void PriceRead(decimal price);

public class GoldPriceReader 
{
    public event PriceRead? PriceRead;
    private int _currentGoldPrice;
    
    public void ReadCurrentPrice()
    {
        _currentGoldPrice = new Random().Next(
            20_000,50_000);

    }

   
}

public class EmailPriceChangeNotifier : IObserver<decimal>
{
    private readonly decimal _notifiationThreashold;

    public EmailPriceChangeNotifier(
        decimal notifiationThreashold)
    {
        _notifiationThreashold = notifiationThreashold;
    }
    public void Update(decimal price)
    {
        if(price > _notifiationThreashold)
        {
            //imagine this is actually sending an email
            Console.WriteLine(
                $"Sending an email saying that " +
                $"the gold price exceed {_notifiationThreashold}" +
                $"and is now {price}\n");
        }
    }
}

public class PushPriceChangeNotifier : IObserver<decimal>
{
    private readonly decimal _notificationThreashold;

    public PushPriceChangeNotifier( decimal notificationThreashold )
    {
        _notificationThreashold = notificationThreashold;
    }

    public void Update(decimal price)
    {
        if(price > _notificationThreashold)
        {
            Console.WriteLine(
                $"Sending a push notification saying that " +
                $"the gold price exceeded {_notificationThreashold}" +
                $"and is now {price}\n");
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
