var rectangle1 = new Rectangle(5, 10);
var calculator = new ShapeMeasurementsCalculator();

Console.WriteLine($"Width is {rectangle1.Width}");
rectangle1.Width = 15;
Console.WriteLine($"Height is {rectangle1.GetHeight()}");
Console.WriteLine($"Area is {calculator.CalculateRectangleArea(rectangle1)}");
Console.WriteLine($"Circumference is {calculator.CalculateRectangleCircumference(rectangle1)}");

var rectangle2 = new Rectangle(2, 3);

Console.WriteLine($"Width is {rectangle2.Width}");
Console.WriteLine($"Height is {rectangle1.GetHeight()}");
Console.WriteLine($"Area is {rectangle2.CalculateArea()}");
Console.WriteLine($"Circumference is {rectangle2.CalculateCircumference()}");


Console.ReadKey();
class Rectangle
{
    //const int NumberOfSides = 4;
    //readonly int NumberOfSidesReadonly;


    public Rectangle(int width, int height)
    {
        //NumberOfSidesReadonly = 4;
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));



    }

    private int _width;

    public int Width
    {
        get => _width;
        set => _width = value;
    }
    

    private int _height;

    public int GetHeight() => _height;

    public void SetHeight(int value)
    {

        if (value > 0)
        {
            _height = value;
        }

    }

    private int GetLengthOrDefault(int length, string name)
    {
        const int defaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueIfNonPositive;
        }
        return length;
    }

    public int CalculateCircumference() => 2 * Width + 2 * _height;


    public int CalculateArea() => Width * _height;

    public string Description => $"A rectangle with width {Width} " +
        $"and height {_height}";

}

class ShapeMeasurementsCalculator
{
    public int CalculateRectangleCircumference(Rectangle rectangle)
    {
        return 2 * rectangle.Width + 2 * rectangle.GetHeight();
    }
    public int CalculateRectangleArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.GetHeight();
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

