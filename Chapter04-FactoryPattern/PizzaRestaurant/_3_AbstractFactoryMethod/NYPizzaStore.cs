using PizzaRestaurant._3_AbstractFactoryMethod.IngredientsFactory;
using PizzaRestaurant._3_AbstractFactoryMethod.Pizzas;

namespace PizzaRestaurant._3_AbstractFactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(string type)
        {
            Pizza? pizza = null;
            IPizaaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("cheese"))
                pizza = new CheesePizza("New York Style Cheese Pizza", ingredientFactory);

            else if (type.Equals("veggie"))
                return new VeggiePizza("New York Style Veggie Pizza", ingredientFactory);

            return pizza;
        }
    }
}
