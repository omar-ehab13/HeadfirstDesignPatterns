using PizzaRestaurant._1_SimpleFactoryPattern.Pizzas;

namespace PizzaRestaurant._1_SimpleFactoryPattern
{
    public class SimplePizzaFactory
    {
        // By encapsulating the pizza creating in one class, we now have one place to make 
        // modifications when the implementation changes.
        // Many clients can use this factory method
        public Pizza? CreatePizza(string type)
        {
            Pizza? pizza = null;

            if (type.Equals("cheese"))
                pizza = new CheesePizza();
            else if (type.Equals("pepperoni"))
                pizza = new PepperoniPizza();
            else if (type.Equals("veggie"))
                pizza = new VeggiePizza();

            return pizza;
        }
    }
}
