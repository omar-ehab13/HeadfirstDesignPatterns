namespace Weather_O_Rama._2_ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temp;
        private float _humidity;
        private WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            this._weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            this._temp = _weatherData.GetTemperature();
            this._humidity = _weatherData.GetHumidity();

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {_temp}F degrees and {_humidity}% humidity");
        }
    }
}
