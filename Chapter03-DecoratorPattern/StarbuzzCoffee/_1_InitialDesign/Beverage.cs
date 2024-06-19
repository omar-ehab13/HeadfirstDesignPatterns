namespace StarbuzzCoffee._1_InitialDesign
{
    public class Beverage
    {
        public string? Description { get; set; }
        // Problem:
        //   When condiments cost change we want to alter here in Beverage class
        // Problem:
        //   When new condiment added we will add new cost property and new hasCodiment method and property
        //   but what if we have many of condiments this Beverage class will be spaghetti!!
        private double _milkCost = 0.15;
        private double _whipCost = 0.10;
        private double _mochaCost = 0.20;
        private double _soyCost = 0.15;

        private byte hasMilk = 0;
        private byte hasSoy = 0;
        private byte hasMocha = 0;
        private byte hasWhip = 0;

        public virtual double Cost()
        {
            double condimentCost = 0.0;

            // Problem:
            //   When we add new condiment we want to change in Cost() method logic
            if (HasMilk())
                condimentCost += _milkCost;
            if (HasMocha())
                condimentCost += _mochaCost;
            if (HasSoy())
                condimentCost += _soyCost;
            if (HasWhip())
                condimentCost += _whipCost;

            return condimentCost;
        }

        public void SetMilk()
        {
            hasMilk = 1;
        }

        public void SetMocha()
        {
            hasMocha = 1;
        }

        public void SetSoy()
        {
            hasSoy = 1;
        }

        public void SetWhip()
        {
            hasWhip = 1;
        }

        public bool HasMilk()
        {
            return hasMilk == 1;
        }

        public bool HasMocha()
        {
            return hasMocha == 1;
        }

        public bool HasSoy()
        {
            return hasSoy == 1;
        }

        public bool HasWhip()
        {
            return hasWhip == 1;
        }
    }
}
