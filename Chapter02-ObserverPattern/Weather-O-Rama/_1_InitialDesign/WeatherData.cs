namespace Weather_O_Rama._1_InitialDesign
{
    public class WeatherData
    {
        private float _temp;
        private float _humidity;
        private float _pressure;

        public CurrentConditionsDisplay CurrentConditionsDisplay { get; set; }
        public StatisticsDisplay StatisticsDisplay { get; set; }
        public ForecastDisplay ForecastDisplay { get; set; }

        public void MeasurementChanged()
        {
            float temp = GetTemperature();
            float humidity = GetHumidity();
            float pressure = GetPressure();


            // Problem Here:
            //   By coding to concrete implementations, we have no way to add or remove other display elements
            //   without making changes to the code.
            CurrentConditionsDisplay.Update(temp, humidity, pressure);
            StatisticsDisplay.Update(temp, humidity, pressure);
            ForecastDisplay.Update(temp, humidity, pressure);
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            this._temp = temp;
            this._humidity = humidity;
            this._pressure = pressure;

            MeasurementChanged();
        }

        public float GetTemperature()
        {
            return _temp;
        }

        public float GetHumidity()
        {
            return _humidity;
        }

        public float GetPressure()
        {
            return _pressure;
        }
    }
}
