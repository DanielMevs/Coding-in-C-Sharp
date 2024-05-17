namespace DotNetUnderTheHood.Exercises
{
    public class FirstDayOfSummer
    {
        public static void FastForwardToSummer(ref DateTime dateTimeObj)
        {
            var firstDayOfSummer = new DateTime(dateTimeObj.Year, 06, 21);
            if (dateTimeObj >= firstDayOfSummer)
            {
                return;
            }
            else
            {
                dateTimeObj = firstDayOfSummer;
            }

        }
    }
}
