using PizzaRestaurant._1_SimpleFactoryPattern.Pizzas;

namespace PizzaRestaurant._1_SimpleFactoryPattern
{
    public class PizzaStore
    {
        private SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this._factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            // The client knows the factory will create the pizza,
            // and doesn't interest in the logic of creating this pizza.
            Pizza? pizza = this._factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
