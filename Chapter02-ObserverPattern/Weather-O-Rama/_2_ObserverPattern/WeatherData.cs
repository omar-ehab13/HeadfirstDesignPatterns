namespace Weather_O_Rama._2_ObserverPattern
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float _temp;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
                observer.Update();
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
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
