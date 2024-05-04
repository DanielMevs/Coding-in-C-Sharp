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

            var numbers = new[] { 10, 1, 4, 17, 122 };
            var evenNumbers = numbers.Where(number => number % 2 == 0);
            Printer.Print(evenNumbers, nameof(evenNumbers));

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

            var heavierThan10Kilos = pets.Where(pet => pet.Weight > 10);
            Printer.PrintPets(heavierThan10Kilos, nameof(heavierThan10Kilos));

            var heavierThan100Kilos = pets.Where((pet) => pet.Weight > 100);
            Printer.Print(heavierThan100Kilos, nameof(heavierThan100Kilos));

            var verySpecificPets = pets.Where(pet =>
                (pet.Type == PetType.Cat || 
                pet.Type == PetType.Dog) &&
                pet.Weight > 10 &&
                pet.Id % 2 == 0);
            Printer.PrintPets(verySpecificPets, nameof(verySpecificPets));

            var indexesSelectedByUser = new[] { 1, 6, 7 };
            var petsSelectedByUserAndLighterThan5Kilos = pets
                .Where((pet, index) =>
                    pet.Weight < 5 &&
                    indexesSelectedByUser.Contains(index));

            Printer.PrintPets(petsSelectedByUserAndLighterThan5Kilos,
                nameof(petsSelectedByUserAndLighterThan5Kilos));

            int countOfHeavyPets1 = pets.Count(pet => pet.Weight > 30);
            int countOfHeavyPets2 = pets
                .Where(pet => pet.Weight > 30).Count();

            Console.WriteLine($"{nameof(countOfHeavyPets1)}:" +
                $" {countOfHeavyPets1}");
            Console.WriteLine($"{nameof(countOfHeavyPets2)}:" +
                $" {countOfHeavyPets2}");
            
            //var numbers = new[] { 16, 8, 9, -1, 2 };
            //var firstNumber = numbers.First();
            //Console.WriteLine("first number: " + firstNumber);

            //var firstOdd = numbers.First(number => number % 2 == 1);
            //Console.WriteLine("First odd: " + firstOdd);
            //var lastPetHeavierThan100 = pets.Last(pet => pet.Weight > 100);
            //var lastPetHeavierThan100 = pets
            //    .LastOrDefault(pet => pet.Weight > 100);
            //Console.WriteLine(nameof(lastPetHeavierThan100) + lastPetHeavierThan100);

            //var heaviestPet = pets.OrderBy(pet => pet.Weight).Last();
            //Printer.PrintPet(heaviestPet, nameof(heaviestPet));

            //var numbers = new[] { 16, 8, 9, -1, 2 };
            //bool is7Present = numbers.Contains(7);
            //Console.WriteLine("Is 7 present: " + is7Present);

            //var words = new[] { "lion", "tiger", "snow leopard" };
            //bool isTigerPresent = words.Contains("tiger");
            //Console.WriteLine("Is tiger present: " + isTigerPresent);
            //var numbers = new[] { 5, 9, 2, 12, 6 };
            //var areAllLargerThanZero = numbers.All(number => number > 0);
            //Console.WriteLine(
            //    "Are all numbers larger than zero: "
            //    + areAllLargerThanZero
            //);
            //bool isAnyLargerThan10 = numbers.Any(number => number > 10);
            //Console.WriteLine(isAnyLargerThan10);
            //var petsOrderedByName = pets.OrderBy(pet => pet.Name);
            //Printer.PrintPets(petsOrderedByName, nameof(petsOrderedByName));

            //var petsOrderedByIdDescending = pets.OrderByDescending(pet => pet.Id);
            //Printer.PrintPets(petsOrderedByIdDescending, nameof(petsOrderedByIdDescending));

            //var numbers = new[] { 16, 8, 9, -1, 2 };
            //var orderedNumbers = numbers.OrderBy(number => number);
            //Printer.Print(orderedNumbers, nameof(orderedNumbers));


            //var words = new[] { "lion", "tiger", "snow leopard" };
            //var orderedWordsDesc = words.OrderByDescending(word => word);
            //Printer.Print(orderedWordsDesc, nameof(orderedWordsDesc));

            //var petsOrderedByTypeThenName = pets
            //    .OrderBy(pet => pet.Type)
            //    .ThenBy(pet => pet.Name);
            //Printer.PrintPets(
            //    petsOrderedByTypeThenName, nameof(petsOrderedByTypeThenName));
            //var countOfDogs = pets.Count(pet => pet.Type == PetType.Dog);
            //Console.WriteLine(countOfDogs);

            //var countOfPetsNamedBruce = pets.LongCount(pet => pet.Name == "Bruce");
            //Console.WriteLine("Count of dogs named Bruce: " + countOfPetsNamedBruce);

            //var countOfAllSmallDogs = pets.Count(pet =>
            //    pet.Type == PetType.Dog &&
            //    pet.Weight < 10);

            //Console.WriteLine("Small dogs count: " + countOfAllSmallDogs);

            //var allPetsCount = pets.Count();
            //Console.WriteLine("All pets count: " + allPetsCount);
            //var doAllHaveNonEmptyNames = pets.All(pet =>
            //    !string.IsNullOrEmpty(pet.Name));

            //Console.WriteLine(
            //    "Do all pets have non empty names:" +
            //    doAllHaveNonEmptyNames
            //);

            //var areAllCats = pets.All(
            //    pet => pet.Type == PetType.Cat);

            //Console.WriteLine("Are all pets cats: " + areAllCats);
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
    public static class Printer
    {
        public static void PrintPets(IEnumerable<Pet> pets, string petsName)
        {
            Console.WriteLine(petsName);
            foreach(var pet in pets)
            {
                Console.WriteLine(
                    $"Id: {pet.Id} " +
                    $"Name: {pet.Name} " +
                    $"Type: {pet.Type} " +
                    $"Weight: {pet.Weight}"
                    );
            }
            Console.WriteLine();
        }
        public static void PrintPet(Pet pet, string petName)
        {
            Console.WriteLine();

            Console.WriteLine(
                petName + ": " +
                $"Id: {pet.Id} " +
                $"Name: {pet.Name} " +
                $"Type: {pet.Type} " +
                $"Weight: {pet.Weight}"
            );
    
            Console.WriteLine();
        }
        public static void Print<T>(IEnumerable<T> items, string itemsName)
        {
            Console.WriteLine(itemsName);
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
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