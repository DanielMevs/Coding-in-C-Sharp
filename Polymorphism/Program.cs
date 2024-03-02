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

//Ingredient ingredient = new Cheddar(2, 12);

//Ingredient randomIngredient = GenerateRandomIngredient();
//Console.WriteLine("Random ingredient is " + randomIngredient);

//Console.WriteLine("is object?" + (ingredient is object));
//Console.WriteLine("is ingredient?" + (ingredient is Ingredient));
//Console.WriteLine("is cheddar?" + (ingredient is Cheddar));
//Console.WriteLine("is mozzarella?" + (ingredient is Mozarella));
//Console.WriteLine("is tomato sauce?" + (ingredient is TomatoSauce));

//if(randomIngredient is Cheddar cheddar)
//{

//    Console.WriteLine("cheddar object: " + cheddar);
//}

//Ingredient nullIngredient = null;
//if (nullIngredient != null)
//if(nullIngredient is not null)
//{
//    Console.WriteLine(nullIngredient.Name);
//}

//Ingredient ingredient = GenerateRandomIngredient();

// Will cause an exception if cast fails
//Cheddar cheddar = (Cheddar)ingredient;

// Will give null if cast fails
//Cheddar cheddar = ingredient as Cheddar;

//if (cheddar != null)
//{
//    Console.WriteLine(cheddar.Name);
//}
//else
//{
//    Console.WriteLine("Conversion falied");
//}
using Polymorphism.Extensions;
using System.Text.Json;

//var cheddar = new Cheddar(2, 12);
//var tomatoSauce = new TomatoSauce(1);
//cheddar.Prepare();
//tomatoSauce.Prepare();

//var ingredients = new List<Ingredient>()
//{
//    new Cheddar(2, 10),
//    new Mozarella(2),
//    new TomatoSauce(1)
//};

//foreach (Ingredient ingredient in ingredients)
//{
//    ingredient.Prepare();
//}


//var pizza = RandomPizzaGenerator.Generate(3);

//var multilineText = @"aaaa
//bbbb
//cccc
//dddd";

//Console.WriteLine("Count of lines is " + CountLines(multilineText));
//Console.WriteLine("Count of lines is " + multilineText.CountLines());
//Console.WriteLine("Count of lines is "
//    + StringExtensions.CountLines(multilineText));

//Console.WriteLine("Next after spring is " + Season.Spring.Next());
//Console.WriteLine("Next after winter is " + Season.Winter.Next());

//var bakeableDishes = new List<IBakeable>
//{
//    new Pizza(),
//    new Panettone()
//};

//foreach (var bakeableDish in bakeableDishes)
//{
//    Console.WriteLine(bakeableDish.GetInstructions());
//}

using System.Text.Json;

var person = new Person
{
    FirstName = "John",
    LastName = "Smith",
    YearOfBirth = 1972
};

var asJson = JsonSerializer.Serialize(person);
Console.WriteLine("As JSON: ");
Console.WriteLine(asJson);

var personJson = "{\"FirstName\":\"John\",\"LastName\":\"Smith\",\"YearOfBirth\":1972}";
var personFromJson = JsonSerializer.Deserialize<Person>(personJson);

Console.ReadKey();

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }
}

    public abstract class Dessert
    {

    }

    public interface IBakeable
    {
        string GetInstructions();
    }

    public class Panettone : Dessert, IBakeable
    {
        public string GetInstructions() =>
            "Bake at 180 degrees Celsius for 35 minutes.";
    }

    public class Pizza : IBakeable
    {
        public Ingredient ingredient;
        private List<Ingredient> _ingredients = new List<Ingredient>();
        public void AddIngredient(Ingredient ingredient) =>
            _ingredients.Add(ingredient);

        public string GetInstructions() =>
            "Bake at 250 degrees Celsius for 10 minutes, " +
            "ideally on a stone";

        public override string ToString() =>
            $"This is a pizza with {string.Join(", ", _ingredients)}";
    }
    public static class RandomPizzaGenerator
    {
        public static Pizza Generate(int howManyIngredients)
        {
            var pizza = new Pizza();
            for (int i = 0; i < howManyIngredients; i++)
            {
                var randomIngredient = GenerateRandomIngredient();
                pizza.AddIngredient(randomIngredient);
            }
            return pizza;
        }
        private static Ingredient GenerateRandomIngredient()
        {
            var random = new Random();
            var number = random.Next(1, 4);
            if (number == 1)
            {
                return new Cheddar(2, 12);
            }
            if (number == 2)
            {
                return new TomatoSauce(1);
            }
            else
            {
                return new Mozarella(2);
            }
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

    //public class SpecialRandomPizzaGenerator: RandomPizzaGenerator
    //{

    //}



    public abstract class Ingredient
    {
        public Ingredient(int priceIfExtraTopping)
        {
            Console.WriteLine("Constructor from the Ingredient class");
            PriceIfExtraTopping = priceIfExtraTopping;
        }
        public int PriceIfExtraTopping { get; }
        public override string ToString() => Name;
        public virtual string Name { get; } = "Some ingredient";

        public abstract void Prepare();

        public int PublicField;
        public string PublicMethod() =>
            "This method is PUBLIC in the Ingredient class.";
        protected string ProtectedMethod() =>
            "This method is PROTECTED in the Ingredient class.";
        private string PrivateMethod() =>
            "This method is PRIVATE in the Ingredient class.";
    }
    public abstract class Cheese : Ingredient
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

        public sealed override void Prepare() =>
            Console.WriteLine("Cook tomatoes with basil, garlic and salt. " +
                "Spread on pizza.");
    }

    public class SpecialTomatoSauce : TomatoSauce
    {
        public SpecialTomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
        {
        }

        //public override void Prepare() =>
        //    Console.WriteLine("Special tomato sauce");
    }

    //public class MyBetterString: string
    //{

    //}

    // Used to illustrate the diamond problem
    public class ItalianFoodItem
    {

    }

    public sealed class Mozarella : Cheese
    {
        public Mozarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
        {
        }

        public override string Name => "Mozarella";
        public bool IsLight { get; }

        public override void Prepare() =>
            Console.WriteLine("Slice thinly and place on top of the pizza.");
    }
    //public class SpecialMozzarella: Mozarella
    //{
    //}
    public class Cheddar : Cheese
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

        public override void Prepare() =>
            Console.WriteLine("Grate and sprinkle over pizza");

        public void UseMethodsFromBaseClass()
        {
            Console.WriteLine(PublicMethod());
            Console.WriteLine(ProtectedMethod());
            //Console.WriteLine(PrivateMethod());
        }
    }

