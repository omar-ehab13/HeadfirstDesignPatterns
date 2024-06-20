using PizzaRestaurant._3_AbstractFactoryMethod.Ingredients;

namespace PizzaRestaurant._3_AbstractFactoryMethod.IngredientsFactory
{
    public class NYPizzaIngredientFactory : IPizaaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new RegianoCheese();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public List<Veggie> CreateVeggies()
        {
            return new List<Veggie> { new Onion(), new Garlic(), new Mushroom(), new RedPepper() };
        }
    }
}
