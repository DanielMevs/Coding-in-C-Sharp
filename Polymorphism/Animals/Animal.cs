namespace Polymorphism.Animals
{
    interface IAnimal
    {
        //public virtual void MakeSound() =>
        //    Console.WriteLine("Make a generic animal sound.");
        void MakeSound();
    }
    interface IHousePet : IAnimal
    {
        //public override void MakeSound() =>
        //    Console.WriteLine("<noices of happiness when human comes home>");
        void TaketoVet();
    }
    interface IFeline: IAnimal
    {
        //public override void MakeSound() =>
        //    Console.WriteLine("purr purr");
        void HideInCardboardBox();
    }
    // Used to illustrate the diamond problem
    //class DomesticCat : Feline, HousePet
    //{

    //}
    class DomesticCatImplementingInterfaces : IFeline, IHousePet
    {
        public void HideInCardboardBox() =>
            Console.WriteLine("Hide in any cardboard box in sight");

        public void MakeSound()
        {
            Console.WriteLine("Purr purr.");
        }

        public void TaketoVet() =>
            Console.WriteLine("Take to Dr. Paws using a carrier");
    }
}

namespace Polymorphism.Flyables
{
    public interface IFlyable
    {
        void Fly();
    }
    public class Bird : IFlyable
    {
        public void Tweet() =>
            Console.WriteLine("Tweet, tweet!");

        public void Fly() =>
            Console.WriteLine("Flying using its wings.");
    }
    public class Kite : IFlyable
    {
        public void Fly() =>
            Console.WriteLine("Flying carried by the wind.");
    }

    public class Plane : IFlyable
    {
        public void Fly() =>
            Console.WriteLine("Flying using jet propulsion.");
    }
}
