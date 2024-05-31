namespace AdvancedC_Types.Exercises
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MustBeLargerThanAttribute : Attribute
    {
        public int Min {  get; }
        public MustBeLargerThanAttribute(int min)
        {
            Min = min;
        }
        
        

    }
}
