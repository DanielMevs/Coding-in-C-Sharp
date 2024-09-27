const int threshold = 30_000;

var emailPriceChangeNotifier = new EmailPriceChangeNotifier(
        threshold);

var pushPriceChangeNotifier = new PushPriceChangeNotifier(
        threshold);

var goldPriceReader = new GoldPriceReader(
    emailPriceChangeNotifier,
    pushPriceChangeNotifier);

for(int i = 0; i < 3; ++i)
{
    goldPriceReader.ReadCurrentPrice();
}

Console.ReadKey();

public class GoldPriceReader
{
    private int _currentGoldPrice;
    private readonly EmailPriceChangeNotifier _emailPriceChangeNotifier;
    private readonly PushPriceChangeNotifier _pushPriceChangeNotifier;

    public GoldPriceReader(
        EmailPriceChangeNotifier emailPriceChangeNotifier,
        PushPriceChangeNotifier pushPriceChangeNotifier)
    {
        _emailPriceChangeNotifier = emailPriceChangeNotifier;
        _pushPriceChangeNotifier = pushPriceChangeNotifier;
    }

    public void ReadCurrentPrice()
    {
        _currentGoldPrice = new Random().Next(
            20_000,50_000);

        _emailPriceChangeNotifier.Update(_currentGoldPrice);
        _pushPriceChangeNotifier.Update(_currentGoldPrice);
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

public class PushPriceChangeNotifier
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
