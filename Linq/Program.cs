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
            var numbers = new[] { 5, 9, 2, 12, 6 };
            var areAllLargerThanZero = numbers.All(number => number > 0);
            Console.WriteLine(
                "Are all numbers larger than zero: "
                + areAllLargerThanZero
            );
            //bool isAnyLargerThan10 = numbers.Any(number => number > 10);
            //Console.WriteLine(isAnyLargerThan10);

            var pets =
            new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f),
                new Pet(4, "Taiga", PetType.Dog, 35f),
                new Pet(5, "Rex", PetType.Dog, 40f),
                new Pet(6, "Lucky", PetType.Dog, 5f),
                new Pet(7, "Storm", PetType.Cat, 0.9f),
                new Pet(8, "Nyan", PetType.Cat, 2.2f)

            };
            var doAllHaveNonEmptyNames = pets.All(pet =>
                !string.IsNullOrEmpty(pet.Name));

            Console.WriteLine(
                "Do all pets have non empty names:" +
                doAllHaveNonEmptyNames
            );

            var areAllCats = pets.All(
                pet => pet.Type == PetType.Cat);

            Console.WriteLine("Are all pets cats: " + areAllCats);
            //var isAnyPetNamedBruce = pets.Any(pet => pet.Name == "Bruce");
            //Console.WriteLine("is any pet named Bruce: " +  isAnyPetNamedBruce);

            //var isAnyFish = pets.Any(pet => pet.Type == PetType.Fish);
            //Console.WriteLine("is any pet a fish: " + isAnyFish);

            //var isThereAVerySpecificPet = pets.Any(pet =>
            //    pet.Name.Length > 6 && pet.Id % 2 == 0);
            //Console.WriteLine("is there a very specific pet: " + isThereAVerySpecificPet);

            //var isNotEmpty = pets.Any();

            //var words = new List<string> { "a",  "bb", "ccc", "dddd" };

            //var shortWords = words.Where(word => word.Length < 3).ToList();

            //Console.WriteLine("First iteration");
            //foreach (var word in shortWords)
            //{
            //    Console.WriteLine(word);
            //}
            //words.Add("e");

            //Console.WriteLine("Second iteration");
            //foreach (var word in shortWords)
            //{
            //    Console.WriteLine(word);
            //}
            //var people = new List<Person>
            //{
            //    new Person("John", "USA"),
            //    new Person("Betty", "UK")
            //};
            //var allAmericans = people.Where(
            //    person => person.Country == "USA");

            //var notAllAmericans = allAmericans.Take(100);

            //var animals = new List<string>()
            //{
            //    "Duck", "Lion", "Dolphin", "Tiger"
            //};
            //var animalsWithD = animals.Where(
            //    animal =>
            //    {
            //        Console.WriteLine("Checking animals: " + animal);
            //        return animal.StartsWith('D');
            //    });
            //foreach(var animal in animalsWithD)
            //{
            //    Console.WriteLine(animal);
            //}
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
    public enum PetType
    {
        Fish,
        Cat,
        Dog
    }
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PetType Type { get; set; }
        public float Weight { get; set; }
        public Pet(int id, string name, PetType type, float weight)
        {
            Id = id;
            Name = name;
            Type = type;
            Weight = weight;
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