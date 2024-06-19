namespace StarbuzzCoffee._2_DecoratorPattern.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return Beverage.Cost() + 0.15;
        }
    }
}
