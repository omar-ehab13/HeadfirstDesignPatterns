namespace Weather_O_Rama._1_InitialDesign
{
    public class CurrentConditionsDisplay
    {
        private float _temp;
        private float _humidity;

        public void Update(float temp, float humidity, float pressure)
        {
            this._temp = temp;
            this._humidity = humidity;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {_temp} F degrees and {_humidity} % humidity");
        }
    }
}
