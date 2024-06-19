namespace Weather_O_Rama._2_ObserverPattern
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _currentPressure = 29.92f;
        private float _lastPressure;
        private WeatherData _weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            this._weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            this._lastPressure = _currentPressure;
            this._currentPressure = _weatherData.GetPressure();

            Display();
        }

        public void Display()
        {
            // Display Code Here
            Console.WriteLine("Forecast Display");
        }
    }
}
