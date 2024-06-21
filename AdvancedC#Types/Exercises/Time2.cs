namespace AdvancedC_Types.Exercises
{
    public struct Time2
    {
        public int Hour { get; }
        public int Minute { get; }

        public Time2(int hour, int minute)
        {
            if (hour < 0 || hour > 23)
            {
                throw new ArgumentOutOfRangeException(
                    "Hour is out of range of 0-23");
            }
            if (minute < 0 || minute > 59)
            {
                throw new ArgumentOutOfRangeException(
                    "Minute is out of range of 0-59");
            }
            Hour = hour;
            Minute = minute;
        }

        public override string ToString() =>
            $"{Hour.ToString("00")}:{Minute.ToString("00")}";

        //your code goes here
        public static bool operator ==(Time2 time1, Time2 time2) =>
            time1.Equals(time2);
        public static bool operator !=(Time2 time1, Time2 time2) =>
            !time1.Equals(time2);

        public static Time2 operator +(Time2 time1, Time2 time2)
        {
            int newHour = time1.Hour + time2.Hour;
            newHour = newHour % 24;
            int newMinute = time1.Minute + time2.Minute;
            if (newMinute > 60)
            {
                newHour += (int)decimal.Round(newMinute / 60);
                newHour = newHour % 24;
            }
            newMinute = newMinute % 60;
            return new Time2(newHour, newMinute);
        }
    }
}
