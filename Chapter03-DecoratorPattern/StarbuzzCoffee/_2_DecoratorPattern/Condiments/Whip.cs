namespace StarbuzzCoffee._2_DecoratorPattern.Condiments
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return Beverage.Cost() + 0.10;
        }
    }
}
