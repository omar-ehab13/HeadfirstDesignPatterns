namespace StarbuzzCoffee._2_DecoratorPattern.Condiments
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Steamed Milk";
        }

        public override double Cost()
        {
            return Beverage.Cost() + 0.10;
        }
    }
}
