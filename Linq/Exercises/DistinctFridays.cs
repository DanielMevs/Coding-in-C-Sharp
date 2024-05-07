namespace LinqTutorial.Exercises
{
    public class DistinctFridays
    {
        public static IEnumerable<DateTime> GetFridaysOfYear(int year, IEnumerable<DateTime> dates)
        {
            return dates.Where(date =>
                date.Year == year &&
                date.DayOfWeek == DayOfWeek.Friday)
                .Distinct();
        }
    }
}
