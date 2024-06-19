namespace StarbuzzCoffee._2_DecoratorPattern.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage { get; set; } = null!;

        public abstract override string GetDescription();
    }
}
