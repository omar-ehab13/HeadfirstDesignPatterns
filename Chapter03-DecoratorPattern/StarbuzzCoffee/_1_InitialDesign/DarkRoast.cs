namespace StarbuzzCoffee._1_InitialDesign
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Most Excellent Dark Roast";
        }

        public override double Cost()
        {
            return base.Cost() + 0.99;
        }
    }
}
