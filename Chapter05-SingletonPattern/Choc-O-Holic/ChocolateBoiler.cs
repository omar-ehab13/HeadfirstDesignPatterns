namespace Choc_O_Holic
{
    public class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;

        private static readonly object padlock = new object();
        private volatile static ChocolateBoiler uniqueInstance;

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler Instance
        {
            get
            {
                lock (padlock)
                {
                    if (uniqueInstance is null)
                        uniqueInstance = new ChocolateBoiler();

                    return uniqueInstance;
                }
            }
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                // Drain the boiled milk and chocolate
                _empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                // Bring the contents to a boil
                _boiled = true;
            }
        }

        private bool IsBoiled()
        {
            return _boiled;
        }

        private bool IsEmpty()
        {
            return _empty;
        }
    }
}