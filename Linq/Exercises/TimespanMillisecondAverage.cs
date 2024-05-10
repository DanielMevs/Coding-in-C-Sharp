namespace LinqTutorial.Exercises
{
    public class TimespanMillisecondAverage
    {
        public static double CalculateAverageDurationInMilliseconds(IEnumerable<TimeSpan> timeSpans)
        {
            if (timeSpans.Count() == 0)
            {
                throw new Exception("Empty list.");
            }

            return timeSpans.Select(timeSpan =>
                timeSpan.Milliseconds)
                .Average();
        }
    }
}
