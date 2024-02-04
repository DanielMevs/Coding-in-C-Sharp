namespace Polymorphism.Animals
{
    class Animal
    {
        public virtual void MakeSound() =>
            Console.WriteLine("Make a generic animal sound.");
    }
    class HousePet : Animal
    {
        public override void MakeSound() =>
            Console.WriteLine("<noices of happiness when human comes home>");
    }
    class Feline: Animal
    {
        public override void MakeSound() =>
            Console.WriteLine("purr purr");
    }
    // Used to illustrate the diamond problem
    //class DomesticCat : Feline, HousePet
    //{

    //}
}
