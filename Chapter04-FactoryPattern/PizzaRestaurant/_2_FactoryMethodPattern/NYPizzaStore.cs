using PizzaRestaurant._2_FactoryMethodPattern.Pizzas;

namespace PizzaRestaurant._2_FactoryMethodPattern
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(string type)
        {
            if (type.Equals("cheese"))
                return new NYStyleCheesePizza();

            if (type.Equals("pepperoni"))
                return new NYStylePepperoniPizza();

            if (type.Equals("veggie"))
                return new NYStyleVeggiePizza();

            return null;
        }
    }
}
