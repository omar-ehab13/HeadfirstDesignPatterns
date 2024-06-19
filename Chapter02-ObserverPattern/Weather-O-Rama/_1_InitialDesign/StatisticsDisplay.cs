namespace Weather_O_Rama._1_InitialDesign
{
    public class StatisticsDisplay
    {
        private float _max = 80f;
        private float _min = 80f;
        private float _avg = 80f;

        public void Update(float temp, float humidity, float pressure)
        {
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
