namespace Events.Exercises
{
    public record struct WeatherData(int? Temperature, int? Humidity);

    public class WeatherDataAggregator
    {
        public IEnumerable<WeatherData> WeatherHistory => _weatherHistory;
        private List<WeatherData> _weatherHistory = new();

        public void GetNotifiedAboutNewData(
            object? sender, WeatherDataEventArgs e)
        {
            _weatherHistory.Add(e.WeatherData);
        }
    }


    public class WeatherStation
    {
        public event EventHandler<WeatherDataEventArgs>? WeatherMeasured;

        public void Measure()
        {
            int temperature = 25;

            OnWeatherMeasured(temperature);
        }

        private void OnWeatherMeasured(int temperature)
        {
            WeatherMeasured?.Invoke(
                this,
                new WeatherDataEventArgs(
                    new WeatherData(temperature, null)));
        }
    }

    public class WeatherBaloon
    {
        public event EventHandler<WeatherDataEventArgs>? WeatherMeasured;

        public void Measure()
        {
            int humidity = 50;

            OnWeatherMeasured(humidity);
        }

        private void OnWeatherMeasured(int humidity)
        {
            WeatherMeasured?.Invoke(
                this,
                new WeatherDataEventArgs(
                    new WeatherData(null, humidity)));
        }
    }

    public class WeatherDataEventArgs : EventArgs
    {
        public WeatherData WeatherData { get; }

        public WeatherDataEventArgs(WeatherData weatherData)
        {
            WeatherData = weatherData;
        }
    }
}

