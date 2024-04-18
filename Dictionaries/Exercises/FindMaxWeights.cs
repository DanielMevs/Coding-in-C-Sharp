namespace Dictionaries.Exercises
{
    public class FindMaxWeights
    {
        public static Dictionary<PetType, double> FindPetMaxWeights(List<Pet> pets)
        {
            var petTypeGrouping = new Dictionary<PetType, List<Pet>>();
            foreach (var pet in pets)
            {
                if (!petTypeGrouping.ContainsKey(pet.PetType))
                {
                    petTypeGrouping[pet.PetType] = new List<Pet>();
                }
                petTypeGrouping[pet.PetType].Add(pet);
            }
            var result = new Dictionary<PetType, double>();

            foreach (var petType in petTypeGrouping.Keys)
            {
                double typeMax = 0;
                foreach (var pet in petTypeGrouping[petType])
                {
                    if (pet.Weight > typeMax)
                    {
                        result[petType] = pet.Weight;
                        typeMax = pet.Weight;
                    }
                }
            }
            return result;
        }
    }

    public class Pet
    {
        public PetType PetType { get; }
        public double Weight { get; }

        public Pet(PetType petType, double weight)
        {
            PetType = petType;
            Weight = weight;
        }

        public override string ToString() => $"{PetType}, {Weight} kilos";
    }

    public enum PetType { Dog, Cat, Fish }
}

