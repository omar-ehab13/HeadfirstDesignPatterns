using PizzaRestaurant._2_FactoryMethodPattern.Pizzas;

namespace PizzaRestaurant._2_FactoryMethodPattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(string type)
        {
            if (type.Equals("cheese"))
                return new ChicagoStyleCheesePizza();

            if (type.Equals("pepperoni"))
                return new ChicagoStylePepperoniPizza();

            if (type.Equals("veggie"))
                return new ChicagoStyleVeggiePizza();

            return null;
        }
    }
}
