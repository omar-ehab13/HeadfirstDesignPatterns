namespace Weather_O_Rama._2_ObserverPattern
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float _max = 80f;
        private float _min = 80f;
        private float _avg = 80f;
        private WeatherData _weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            this._weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            float temp = _weatherData.GetTemperature();

            if (temp >= _max)
                _max = temp;
            else if (temp <= _min)
                _min = temp;

            _avg = (_min + _max) / 2;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature: {_avg}/{_max}/{_min}");
        }
    }
}
