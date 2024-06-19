namespace Weather_O_Rama._1_InitialDesign
{
    public class ForecastDisplay
    {
        private float _currentPressure = 29.92f;
        private float _lastPressure;

        public void Update(float temp, float humidity, float pressure)
        {
            this._lastPressure = _currentPressure;
            this._currentPressure = pressure;

            Display();
        }

        public void Display()
        {
            // Display Code Here
            Console.WriteLine("Forecast Display");
        }
    }
}
