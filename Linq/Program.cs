//using System;

//var words = new List<string> { "a", "bb", "ccc", "dddd"};
//var wordsLongerThan2Letters = words.Where(word => word.Length > 2);

//var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
//var oddNumbers = numbers.Where(number => number % 2 == 1);


//Console.ReadLine();

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string> { "a",  "bb", "ccc", "dddd" };

            var shortWords = words.Where(word => word.Length < 3).ToList();

            Console.WriteLine("First iteration");
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }
            words.Add("e");

            Console.WriteLine("Second iteration");
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }
            var people = new List<Person>
            {
                new Person("John", "USA"),
                new Person("Betty", "UK")
            };
            var allAmericans = people.Where(
                person => person.Country == "USA");

            var notAllAmericans = allAmericans.Take(100);

            var animals = new List<string>()
            {
                "Duck", "Lion", "Dolphin", "Tiger"
            };
            var animalsWithD = animals.Where(
                animal =>
                {
                    Console.WriteLine("Checking animals: " + animal);
                    return animal.StartsWith('D');
                });
            foreach(var animal in animalsWithD)
            {
                Console.WriteLine(animal);
            }
            //var numbers = new List<int> { 5, 3, 7, 1, 2, 4 };
            //var numbersWith10 = numbers.Append(10);

            ////Console.WriteLine("Numbers: " + string.Join(", ", numbers));
            ////Console.WriteLine(
            ////    "Numbers with 10: " + string.Join(", ", numbersWith10));

            ////var oddNumbers = numbers.Where(number => number % 2 == 1);
            //var orderedOddNumbers = numbers
            //    .Where(number => number % 2 == 1)
            //    .OrderBy(number => number);

            //Console.WriteLine(
            //    "orderedOddNumbers: " + string.Join(", ", orderedOddNumbers));

            Console.ReadKey();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public Person(string name, string country)
        {
            Name = name;
            Country = country;
        }

    }
    //class LinqExample
    //{
    //    static void Main(string[] args)
    //    {
    //        var wordsNoUpperCase = new string[]
    //        {
    //            "quick", "brown", "fox"
    //        };
    //        Console.WriteLine(IsAnyWordUpperCase(wordsNoUpperCase));
    //        var wordsWithUpperCase = new string[]
    //        {
    //            "quick", "brown", "FOX"
    //        };
    //        Console.WriteLine(IsAnyWordUpperCase(wordsWithUpperCase));
    //        Console.ReadKey();
    //    }
    //    public static bool IsAnyWordUpperCase_Linq(
    //        IEnumerable<string> words)
    //    {
    //        return words.Any(word =>
    //            word.All(letter => char.IsUpper(letter)));
    //    }
    //    public static bool IsAnyWordUpperCase(
    //        IEnumerable<string> words)
    //    {
    //        foreach (var word in words)
    //        {
    //            bool areAllUpperCase = true;
    //            foreach(var letter in word)
    //            {
    //                if (char.IsLower(letter))
    //                {
    //                    areAllUpperCase = false;
    //                }
    //            }
    //            if(areAllUpperCase)
    //            {
    //                return true;
    //            }
    //        }
    //        return false;
    //    }
    //}

}