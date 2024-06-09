namespace AdvancedC_Types.Exercises
{
    public class FullName
    {
        public string First { get; init; }
        public string Last { get; init; }

        public override string ToString() => $"{First} {Last}";

        public override bool Equals(object? obj)
        {
            return obj is FullName other &&
                First == other.First &&
                Last == other.Last;

        }
    }
}
