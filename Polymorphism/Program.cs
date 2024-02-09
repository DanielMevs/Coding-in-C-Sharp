//using Polymorphism.Animals;

//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new Mozarella());
//pizza.AddIngredient(new TomatoSauce());

//Console.WriteLine(pizza);





//Console.WriteLine(new TomatoSauce());
//Console.WriteLine(new HousePet());
//Console.WriteLine(new List<int>());

//Console.WriteLine(123);
//Console.WriteLine(new DateTime(2023, 5, 6));
//Console.WriteLine("hello");

//var ingredient = new Ingredient();
//ingredient.PublicField = 10;

//var cheddar = new Cheddar();
//cheddar.PublicField = 20;

//Console.WriteLine($"Value in ingredient: {ingredient.PublicField}");
//Console.WriteLine($"Value in cheddar: {cheddar.PublicField}");
//Console.WriteLine(cheddar.PublicMethod());
//Console.WriteLine(cheddar.ProtectedMethod());
//Console.WriteLine(cheddar.PrivateMethod());

//Console.WriteLine("Variable of type Cheddar");
//Cheddar cheddar = new Cheddar();
//Console.WriteLine(cheddar.Name);

//Console.WriteLine("Variable of type Ingredient");
//Ingredient ingredient = new Cheddar();
//Console.WriteLine(ingredient.Name);

//var ingredients = new List<Ingredient>
//{
//    new Cheddar(),
//    new Mozarella(),
//    new TomatoSauce()
//};

//foreach(Ingredient ingredient in ingredients)
//{
//   Console.WriteLine(ingredient.Name);
//}

//List<int> numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
//bool shallAddPoitiveOnly = false;

//NumbersSumCalculator calculator = 
//    shallAddPoitiveOnly ?
//    new PositiveNumbersSumCalculator() :
//    new NumbersSumCalculator();

//int sum = calculator.Calculate(numbers);


//Console.WriteLine("Sum is: " + sum);



//int seasonNumber = 0;
// Explicit cast express
//Season spring = (Season)seasonNumber;

// decimals ending with m denote money values
//decimal a = 10.01m;

//int integer = 10;
// Although C# is statically typed,
//an implicit conversion happens
//behind the scenes
//decimal b = integer;

// Explicit conversion
// is necessary in this
// case due to data loss
// or runtime error potential
//decimal c = 10.01m;
//decimal c = 10000000000000000000000000.01m;
//int d = (int)c;

//string s = (string)integer;


//int secondSeasonNumber = 1;
//int secondSeasonNumber = 11;
//Season summer = (Season)secondSeasonNumber;
//Console.WriteLine(summer);


//var ingredient = new Ingredient(1);
//var cheddar = new Cheddar(2, 12);

Ingredient ingredient = new Cheddar(2, 12);

Ingredient randomIngredient = GenerateRandomIngredient();
Console.WriteLine("Random ingredient is " + randomIngredient);

Console.WriteLine("is object?" + (ingredient is object));
Console.WriteLine("is ingredient?" + (ingredient is Ingredient));
Console.WriteLine("is cheddar?" + (ingredient is Cheddar));
Console.WriteLine("is mozzarella?" + (ingredient is Mozarella));
Console.WriteLine("is tomato sauce?" + (ingredient is TomatoSauce));

if(randomIngredient is Cheddar cheddar)
{
    
    Console.WriteLine("cheddar object: " + cheddar);
}

Ingredient nullIngredient = null;
//if (nullIngredient != null)
if(nullIngredient is not null)
{
    Console.WriteLine(nullIngredient.Name);
}


Console.ReadKey();

Ingredient GenerateRandomIngredient()
{
    var random = new Random();
    var number = random.Next(1, 4);
    if(number == 1)
    {
        return new Cheddar(2, 12);
    }
    if(number == 2)
    {
        return new TomatoSauce(1);
    }
    else
    {
        return new Mozarella(2);
    }
}

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

public class PositiveNumbersSumCalculator : NumbersSumCalculator
{
    protected override bool ShallBeAdded(int number)
    {
        return number > 0;
    }

}
public class NumbersSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            if (ShallBeAdded(number))
            {
                sum += number;
            }
            
        }
        return sum;
    }
    protected virtual bool ShallBeAdded(int number)
    {
        return true;
    }
}

public class Pizza
{
    public Ingredient ingredient;
    private List<Ingredient> _ingredients = new List<Ingredient>();
    public void AddIngredient(Ingredient ingredient) => 
        _ingredients.Add(ingredient);
    public override string ToString() => 
        $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from the Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }
    public int PriceIfExtraTopping { get; }
    public override string ToString() => Name;
    public virtual string Name { get; } = "Some ingredient";
    public int PublicField;
    public string PublicMethod() =>
        "This method is PUBLIC in the Ingredient class.";
    protected string ProtectedMethod() =>
        "This method is PROTECTED in the Ingredient class.";
    private string PrivateMethod() =>
        "This method is PRIVATE in the Ingredient class.";
}
public class Cheese : Ingredient
{
    public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }
}
public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Tomato sauce";
    public int TomatoIn100Grams { get; }
}

// Used to illustrate the diamond problem
public class ItalianFoodItem
{

}

public class Mozarella : Cheese
{
    public Mozarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Mozarella";
    public bool IsLight { get; }
}
public class Cheddar : Ingredient
{
    public Cheddar(int priceIfExtraTopping, int agedForMonths) : base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonths;
        Console.WriteLine(
            "Constructor from the Cheddar class");
    }
    public override string Name =>
        $"{base.Name}, more specifically, " +
        $"a cheddar cheese aged for {AgedForMonths} months";
    
    public int AgedForMonths { get; }
    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
        //Console.WriteLine(PrivateMethod());
    }
}
