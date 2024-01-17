var rectangle1 = new Rectangle(5, 10);
var calculator = new ShapeMeasurementsCalculator();

Console.WriteLine($"Width is {rectangle1.Width}");
Console.WriteLine($"Height is {rectangle1.Height}");
Console.WriteLine($"Area is {calculator.CalculateRectangleArea(rectangle1)}");
Console.WriteLine($"Circumference is {calculator.CalculateRectangleCircumference(rectangle1)}");

var rectangle2 = new Rectangle(2, 3);

Console.WriteLine($"Width is {rectangle2.Width}");
Console.WriteLine($"Height is {rectangle2.Height}");
Console.WriteLine($"Area is {rectangle2.CalculateArea()}");
Console.WriteLine($"Circumference is {rectangle2.CalculateCircumference()}");


var appointmentTwoWeeksFromNow = new MedicalAppointment("Bob Smith", 14);
var appointmentOneWeekFromNow = new MedicalAppointment("Margaret Smith");

Console.ReadKey();

class Rectangle
{
    public int Height;
    public int Width;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;

    }

    public int CalculateCircumference() => 2 * Width + 2 * Height;


    public int CalculateArea() => Width * Height;

}

class ShapeMeasurementsCalculator
{
    public int CalculateRectangleCircumference(Rectangle rectangle)
    {
        return 2 * rectangle.Width + 2 * rectangle.Height;
    }
    public int CalculateRectangleArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}


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





public class Triangle
{
    private int _base;
    private int _height;

    public Triangle(int @base, int height)
    {
        _base = @base;
        _height = height;
    }

    public int CalculateArea()
    {
        return (_base * _height) / 2;
    }
    public string AsString()
    {
        return $"Base is {_base}, height is {_height}";
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

    public MedicalAppointment(string patientName="Unknown", int daysFromNow = 7)
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




