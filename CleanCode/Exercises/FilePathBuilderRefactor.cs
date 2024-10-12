namespace CleanCode.Exercises
{
    public class FilePathBuilderRefactor
    {
        public static string BuildFilePathFrom_Refactored(
            DateTime dateTime, Extension extension)
        {
            var day = dateTime.Day;
            var dayOfWeek = dateTime.DayOfWeek;
            var month = dateTime.Month;
            var year = dateTime.Year;

            var fileExtension = extension.ToString().ToLower();
            var result = $"{dayOfWeek}_{day}_{month}_{year}.{fileExtension}";

            return result;

        }

        //do not modify this method!
        public static string BuildFilePathFrom(DateTime d, Extension ex)
        {
            var d1 = d.Day;
            var d2 = d.DayOfWeek;
            var m = d.Month;
            var y = d.Year;

            var format = ex.ToString().ToLower();
            var format2 = $"{d2}_{d1}_{m}_{y}.{format}";

            return format2;
        }

        //do not modify this enum!
        public enum Extension
        {
            Txt,
            Json
        }
    }
}
