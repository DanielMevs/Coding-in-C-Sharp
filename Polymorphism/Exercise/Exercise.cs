namespace Exercise
{
    public class Exercise
    {
        public List<int> GetCountsOfAnimalsLegs()
        {
            var animals = new List<Animal>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider()
            };

            var result = new List<int>();
            foreach (var animal in animals)
            {
                result.Add(animal.NumberOfLegs);
            }
            return result;
        }

        public class Animal
        {
            public virtual int NumberOfLegs { get; } = 4;
        }
        public class Lion : Animal
        {

        }
        public class Tiger : Animal
        {

        }
        public class Duck : Animal
        {
            public override int NumberOfLegs { get; } = 2;
        }
        public class Spider : Animal
        {
            public override int NumberOfLegs { get; } = 8;
        }
    }

    public class Exercise2
    {
        public List<string> ProcessAll(List<string> words)
        {
            var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

            List<string> result = words;
            foreach (var stringsProcessor in stringsProcessors)
            {
                result = stringsProcessor.Process(result);
            }
            return result;
        }

        public class StringsProcessor
        {
            public List<string> Process(
                List<string> strings)
            {
                var result = new List<string>();
                foreach (var text in strings)
                {
                    result.Add(ProcessSingle(text));
                }
                return result;
            }
            protected virtual string ProcessSingle(string input) => input;
        }
        public class StringsUppercaseProcessor : StringsProcessor
        {
            protected override string ProcessSingle(string input) =>
                input.Substring(0, input.Length / 2);
        }
        public class StringsTrimmingProcessor : StringsProcessor
        {
            protected override string ProcessSingle(string input) =>
                input.ToUpper();
        }
    }

}
public static class NumericTypesDescriber
{
    public static string Describe(object someObject)
    {
        if (someObject is int)
        {
            return $"Int of value {someObject}";
        }
        else if (someObject is double)
        {
            return $"Double of value {someObject}";
        }
        else if (someObject is decimal)
        {
            return $"Decimal of value {someObject}";
        }
        else
        {
            return null;
        }

    }
}

public static class ExerciseShapes
{

    public static List<double> GetShapesAreas(List<Shape> shapes)
    {
        var result = new List<double>();

        foreach (var shape in shapes)
        {
            result.Add(shape.CalculateArea());
        }

        return result;
    }
}

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Square : Shape
{
    public double Side { get; }

    public Square(double side)
    {
        Side = side;
    }

    public override double CalculateArea() => Side * Side;
}


public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea() => Height * Width;
}

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea() => Math.PI * (Radius * Radius);
}
