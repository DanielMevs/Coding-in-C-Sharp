var appointmentTwoWeeksFromNow = new MedicalAppointment("Bob Smith", 14);
var appointmentOneWeekFromNow = new MedicalAppointment("Margaret Smith");

Console.ReadKey();

public class HotelBooking
{
    public string GuestName;
    public DateTime StartDate;
    public DateTime EndDate;

    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
        GuestName = guestName;
        StartDate = startDate;
        EndDate = startDate.AddDays(lengthOfStayInDays);

    }

}



class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine($"Appointment will take place on {medicalAppointment.GetDate()}");
    }
}

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public DateTime GetDate() => _date;


    //public MedicalAppointment(string patientName) :
    //    this(patientName, 7)
    //{
    //}

    public MedicalAppointment(string patientName = "Unknown", int daysFromNow = 7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    //public MedicalAppointment(string patientName)
    //{
    //    _patientName=patientName;
    //}

    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }

    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void MoveByMonthsAndDays(int monthToAdd, int daysToAdd)
    {
        _date = new DateTime(
            _date.Year,
            _date.Month + monthToAdd,
            _date.Day + daysToAdd);
    }
}


public class Dog
{
    private string _name;
    private string _breed;
    private int _weight;

    public Dog(string name, string breed, int weight)
    {
        _name = name;
        _breed = breed;
        _weight = weight;
    }

    public Dog(string name, int weight) : this(name, "mixed-breed", weight)
    {
    }

    public string Describe()
    {

        return $"This dog is named {_name}, it's a {_breed}," +
        $" and it weighs {_weight} kilograms, so it's a {DescribeSize()} dog.";
    }
    private string DescribeSize()
    {
        if (_weight < 5)
        {
            return "tiny";
        }
        if (_weight < 30)
        {
            return "medium";
        }
        return "large";

    }
}

public class Order
{
    private string _item;
    private DateTime _date;

    public string Item { get; }
    public DateTime Date
    {
        get
        {
            return _date;
        }
        set
        {
            if (DateTime.Now.Year == value.Year)
            {
                _date = value;
            }
        }
    }


    public Order(string item, DateTime date)
    {
        Item = item;
        Date = date;
    }
}

